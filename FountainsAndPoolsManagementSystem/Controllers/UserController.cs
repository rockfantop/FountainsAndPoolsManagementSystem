using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using FountainsAndPoolsManagementSystem.Hasher;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FountainsAndPoolsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly PasswordHasherSHA256 hasher;

        public UserController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            PasswordHasherSHA256 hasher
            )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.hasher = hasher;
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp ([FromBody] User user)
        {

            var result = await this.userManager.CreateAsync(user, user.Password);

            if (!result.Succeeded)
            {
                return BadRequest(user);
            }
            else
            {
                await this.signInManager.SignInAsync(user, false);

                return Ok(result);
            }
        }

        [HttpPost]
        [Route("signin")]
        public async Task<IActionResult> SignIn([FromBody] User user)
        {
            var dbUser = await this.userManager.FindByNameAsync(user.UserName);

            if (dbUser == null || dbUser.Password != user.Password)
            {
                return Ok("Failed");
            }

            await this.signInManager.SignInAsync(user, false);

            HttpContext.Response.Headers.Add("Access-Control-Expose-Headers", "set-cookie");

            return Ok("Success");
        }
    }
}
