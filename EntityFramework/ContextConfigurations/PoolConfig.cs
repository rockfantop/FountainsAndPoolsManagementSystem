﻿using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class PoolConfig : IEntityTypeConfiguration<Pool>
    {
        public void Configure(EntityTypeBuilder<Pool> builder)
        {
            builder.ToTable("Pools", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();

            builder.HasOne(x => x.Group)
                .WithMany(p => p.Pools)
                .HasForeignKey(pt => pt.GroupId);
        }
    }
}
