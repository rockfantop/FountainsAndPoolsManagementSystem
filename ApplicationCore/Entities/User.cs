using ApplicationCore.Entities.Abstraction;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class User : IdentityUser
    {
        public string Password { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public decimal Balance { get; set; }

        public int TracksAllowed { get; set; } = 5;

        public List<UserPools> Pools { get; set; }

        public List<UserGroups> Groups { get; set; }
    }
}
