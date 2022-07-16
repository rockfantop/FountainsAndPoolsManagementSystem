using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class City : BaseDbEntity
    {
        public string Label { get; set; }

        public List<CityRoad> Roads { get; set; }

        public List<Marker> Markers { get; set; }

        public List<FireStation> FireStation { get; set; }
    }
}
