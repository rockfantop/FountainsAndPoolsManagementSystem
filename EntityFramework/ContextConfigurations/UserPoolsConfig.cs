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
        }
    }
}
