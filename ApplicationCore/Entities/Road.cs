using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Road : BaseDbEntity
    {
        public Guid CityId { get; set; }

        public double StartLong { get; set; }

        public double StartLat { get; set; }

        public double EndLong { get; set; }

        public double EndLat { get; set; }
    }
}
