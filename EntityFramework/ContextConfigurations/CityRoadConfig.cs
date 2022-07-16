using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class CityRoadConfig : IEntityTypeConfiguration<CityRoad>
    {
        public void Configure(EntityTypeBuilder<CityRoad> builder)
        {
            builder.ToTable("CityRoads", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();
        }
    }
}
