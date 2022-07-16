using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class CityRoad : BaseDbEntity
    {
        public Guid RoadId { get; set; }

        public Road Road { get; set; }

        public Guid CityId { get; set; }

        public City City { get; set; }
    }
}
