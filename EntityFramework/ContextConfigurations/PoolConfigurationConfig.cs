using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class PoolConfigurationConfig : IEntityTypeConfiguration<PoolConfiguration>
    {
        public void Configure(EntityTypeBuilder<PoolConfiguration> builder)
        {
            builder.ToTable("PoolConfigurations", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();
        }
    }
}
