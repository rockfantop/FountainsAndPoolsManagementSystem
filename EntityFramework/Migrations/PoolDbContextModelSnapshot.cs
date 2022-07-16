﻿// <auto-generated />
using System;
using EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Migrations
{
    [DbContext(typeof(PoolDbContext))]
    partial class PoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .IsClustered();

                    b.ToTable("Cities", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.CityRoad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoadId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("CityId");

                    b.HasIndex("RoadId");

                    b.ToTable("CityRoads", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.FireStation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CarNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<int>("WorkingPeaple")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("CityId");

                    b.ToTable("FireStations", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .IsClustered();

                    b.ToTable("Groups", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Marker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("CityId");

                    b.ToTable("Markers", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Pool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("ConfigurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<Guid>("MarkerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MarkerId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PoolType")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("GroupId");

                    b.HasIndex("MarkerId1");

                    b.ToTable("Pools", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.PoolConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Chlorine")
                        .HasColumnType("int");

                    b.Property<bool>("Circulation")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<double>("WaterLevel")
                        .HasColumnType("float");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("PoolId");

                    b.ToTable("PoolConfigurations", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.PoolSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConfigurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("ConfigurationId");

                    b.ToTable("PoolSchedules", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Road", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("EndLat")
                        .HasColumnType("float");

                    b.Property<double>("EndLong")
                        .HasColumnType("float");

                    b.Property<double>("StartLat")
                        .HasColumnType("float");

                    b.Property<double>("StartLong")
                        .HasColumnType("float");

                    b.HasKey("Id")
                        .IsClustered();

                    b.ToTable("Roads", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("DECIMAL");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TracksAllowed")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.UserGroups", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .IsClustered();

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups", "dbo");
                });

            modelBuilder.Entity("ApplicationCore.Entities.UserPools", b =>
                {
                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PoolId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPools", "dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ApplicationCore.Entities.CityRoad", b =>
                {
                    b.HasOne("ApplicationCore.Entities.City", "City")
                        .WithMany("Roads")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Road", "Road")
                        .WithMany()
                        .HasForeignKey("RoadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Road");
                });

            modelBuilder.Entity("ApplicationCore.Entities.FireStation", b =>
                {
                    b.HasOne("ApplicationCore.Entities.City", "City")
                        .WithMany("FireStation")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Marker", b =>
                {
                    b.HasOne("ApplicationCore.Entities.City", null)
                        .WithMany("Markers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.Pool", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Group", null)
                        .WithMany("Pools")
                        .HasForeignKey("GroupId");

                    b.HasOne("ApplicationCore.Entities.Marker", "Marker")
                        .WithMany()
                        .HasForeignKey("MarkerId1");

                    b.Navigation("Marker");
                });

            modelBuilder.Entity("ApplicationCore.Entities.PoolConfiguration", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Pool", "Pool")
                        .WithMany("Configurations")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("ApplicationCore.Entities.PoolSchedule", b =>
                {
                    b.HasOne("ApplicationCore.Entities.PoolConfiguration", "Configuration")
                        .WithMany("Schedules")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuration");
                });

            modelBuilder.Entity("ApplicationCore.Entities.UserGroups", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entities.UserPools", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Pool", "Pool")
                        .WithMany("Users")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.User", "User")
                        .WithMany("Pools")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pool");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApplicationCore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApplicationCore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApplicationCore.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationCore.Entities.City", b =>
                {
                    b.Navigation("FireStation");

                    b.Navigation("Markers");

                    b.Navigation("Roads");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Group", b =>
                {
                    b.Navigation("Pools");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Pool", b =>
                {
                    b.Navigation("Configurations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ApplicationCore.Entities.PoolConfiguration", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("ApplicationCore.Entities.User", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Pools");
                });
#pragma warning restore 612, 618
        }
    }
}
