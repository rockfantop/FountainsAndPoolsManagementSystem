using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class UserGroups : BaseDbEntity
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public Guid GroupId { get; set; }

        public Group Group { get; set; }

        public User User { get; set; }
    }
}
