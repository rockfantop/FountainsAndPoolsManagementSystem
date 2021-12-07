using ApplicationCore.Entities.Abstraction;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string Name { get; set; }
    }

    public class User : IdentityUser<Guid>
    {
        public Guid Id { get; set; }

        public string Password { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public decimal Balance { get; set; }

        public int TracksAllowed { get; set; } = 5;

        public List<UserPools> Pools { get; set; }

        public List<UserGroups> Groups { get; set; }
    }
}
