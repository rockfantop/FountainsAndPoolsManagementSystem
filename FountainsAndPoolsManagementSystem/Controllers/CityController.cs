using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FountainsAndPoolsManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IRepository<City> cityRepo;

        public CityController(IRepository<City> cityRepo)
        {
            this.cityRepo = cityRepo;
        }
        
        [HttpGet]
        [Route("getcity")]
        public async Task<IActionResult> GetCity([FromQuery] Guid Id)
        {
            var result = await this.cityRepo.FindAsync(new ApplicationCore.Specification.Specification<City>(x => x.Id == Id));

            return Ok(result);
        }

        [HttpPost]
        [Route("createcity")]
        public async Task<IActionResult> CreateCity([FromBody] City city)
        {
            var result = "";

            try
            {
                city.Id = Guid.NewGuid();

                await this.cityRepo.AddAsync(city);

                await this.cityRepo.SaveChanges();

                result = "Success";
            }
            catch (Exception)
            {
                result = "Failed";
            }

            return Ok(new { result = result, id = city.Id });
        }
    }
}
