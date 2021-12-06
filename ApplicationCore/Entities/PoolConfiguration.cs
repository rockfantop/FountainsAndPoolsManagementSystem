using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class PoolConfiguration : BaseDbEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Chlorine { get; set; }

        public int Temperature { get; set; }

        public bool Circulation { get; set; }

        public Guid PoolId { get; set; }

        public Pool Pool { get; set; }

        public List<PoolSchedule> Schedules { get; set; }
    }
}
