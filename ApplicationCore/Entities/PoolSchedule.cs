using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class PoolSchedule : BaseDbEntity
    {
        public Guid Id { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public Guid ConfigurationId { get; set; }

        public PoolConfiguration Configuration { get; set; }
    }
}
