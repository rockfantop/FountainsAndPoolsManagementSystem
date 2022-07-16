using ApplicationCore.Entities;
using EntityFramework.ContextConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Context
{
    public class PoolDbContext : IdentityDbContext<User>
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

        public DbSet<Group> Group { get; set; }

        public DbSet<UserPools> UserPools { get; set; }

        public DbSet<UserGroups> UserGroups { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<CityRoad> CityRoads { get; set; }

        public DbSet<FireStation> FireStations { get; set; }

        public DbSet<Marker> Markers { get; set; }

        public DbSet<Road> Roads { get; set; }
    }
}
