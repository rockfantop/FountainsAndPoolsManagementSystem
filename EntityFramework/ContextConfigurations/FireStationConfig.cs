using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class FireStationConfig : IEntityTypeConfiguration<FireStation>
    {
        public void Configure(EntityTypeBuilder<FireStation> builder)
        {
            builder.ToTable("FireStations", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();
        }
    }
}
