using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class FireStation : BaseDbEntity
    {
        public bool IsWorking { get; set; }

        public int WorkingPeaple { get; set; }

        public int CarNumber { get; set; }

        public Guid CityId { get; set; }

        public City City { get; set; }
    }
}
