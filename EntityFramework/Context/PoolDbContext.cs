using ApplicationCore.Entities;
using EntityFramework.ContextConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Context
{
    public class PoolDbContext : IdentityDbContext<User, Role, Guid>
    {
        public PoolDbContext(DbContextOptions<PoolDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PoolConfig).Assembly);
        }

        public DbSet<Pool> Pool { get; set; }

        public DbSet<PoolConfiguration> PoolConfiguration { get; set; }

        public DbSet<PoolSchedule> PoolSchedule { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<UserPools> UserPools { get; set; }
    }
}
