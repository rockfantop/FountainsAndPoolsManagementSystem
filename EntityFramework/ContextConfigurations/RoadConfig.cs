using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class RoadConfig : IEntityTypeConfiguration<Road>
    {
        public void Configure(EntityTypeBuilder<Road> builder)
        {
            builder.ToTable("Roads", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();
        }
    }
}
