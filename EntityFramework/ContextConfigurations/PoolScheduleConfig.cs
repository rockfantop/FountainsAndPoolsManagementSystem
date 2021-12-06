using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class PoolScheduleConfig : IEntityTypeConfiguration<PoolSchedule>
    {
        public void Configure(EntityTypeBuilder<PoolSchedule> builder)
        {
            builder.ToTable("PoolSchedules", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();

            builder.HasOne(x => x.Configuration)
                .WithMany(x => x.Schedules)
                .HasForeignKey(x => x.ConfigurationId);
        }
    }
}
