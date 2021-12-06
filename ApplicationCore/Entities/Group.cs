using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Group : BaseDbEntity
    {
        public Guid Id { get; set; }

        public Guid OwnerId { get; set; }

        public string Title { get; set; }

        public List<Pool> Pools { get; set; }

        public List<UserGroups> Users { get; set; }
    }
}
