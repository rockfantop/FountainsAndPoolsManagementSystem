using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    public class UserPoolsConfig : IEntityTypeConfiguration<UserPools>
    {
        public void Configure(EntityTypeBuilder<UserPools> builder)
        {
            builder.ToTable("UserPools", "dbo");

            builder.HasKey(x => new { x.PoolId, x.UserId });

            builder.HasOne(x => x.User)
                .WithMany(p => p.Pools)
                .HasForeignKey(pt => pt.UserId);

            builder.HasOne(x => x.Pool)
                .WithMany(p => p.Users)
                .HasForeignKey(pt => pt.PoolId);
        }
    }
}
