using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class UserPools : BaseDbEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid PoolId { get; set; }

        public Pool Pool { get; set; }

        public User User { get; set; }
    }
}
