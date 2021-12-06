using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ContextConfigurations
{
    class UserGroupsConfig : IEntityTypeConfiguration<UserGroups>
    {
        public void Configure(EntityTypeBuilder<UserGroups> builder)
        {
            builder.ToTable("UserGroups", "dbo");

            builder.HasKey(x => x.Id)
                .IsClustered();

            builder.HasOne(x => x.User)
                .WithMany(p => p.Groups)
                .HasForeignKey(pt => pt.UserId);

            builder.HasOne(x => x.Group)
                .WithMany(p => p.Users)
                .HasForeignKey(pt => pt.GroupId);
        }
    }
}
