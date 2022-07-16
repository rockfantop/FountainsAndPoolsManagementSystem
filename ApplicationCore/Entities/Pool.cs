using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public enum PoolsTypes
    {
        SwimmingPool,
        Fountain,
        Tank,
        Hatch,
        WaterPoint
    }

    public class Pool : BaseDbEntity
    {
        public Guid Id { get; set; }

        public int Width { get; set; }

        public int Length { get; set; }

        public int Height { get; set; }

        public bool Availability { get; set; }

        public PoolsTypes PoolType { get; set; }

        public Guid ConfigurationId { get; set; }

        public Guid OwnerId { get; set; }

        public Marker Marker { get; set; }

        public Guid MarkerId { get; set; }

        public List<UserPools> Users { get; set; }

        public List<PoolConfiguration> Configurations { get; set; }
    }
}
