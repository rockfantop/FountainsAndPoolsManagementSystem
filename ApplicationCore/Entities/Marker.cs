using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Marker : BaseDbEntity
    {
        public double Long { get; set; }

        public double Lat { get; set; }

        public Guid PoolId { get; set; }

        public Guid CityId { get; set; }
    }
}
