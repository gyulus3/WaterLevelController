﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.Migrations
{
    [DbContext(typeof(WaterLevelDbContext))]
    [Migration("20200508155924_CreateWaterLevelDb")]
    partial class CreateWaterLevelDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WaterLevelController.DAL.EfDbContext.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Auto")
                        .HasColumnType("bit");

                    b.Property<int>("MinWaterLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("WaterLevelController.DAL.EfDbContext.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Data")
                        .HasColumnType("int");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("SwitchId")
                        .HasColumnType("int");

                    b.Property<int?>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SwitchId")
                        .IsUnique()
                        .HasFilter("[SwitchId] IS NOT NULL");

                    b.HasIndex("ZoneId");

                    b.ToTable("Sensors");
                });

            modelBuilder.Entity("WaterLevelController.DAL.EfDbContext.Switch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Switches");
                });

            modelBuilder.Entity("WaterLevelController.DAL.EfDbContext.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("WaterLevelController.DAL.EfDbContext.Sensor", b =>
                {
                    b.HasOne("WaterLevelController.DAL.EfDbContext.Schedule", "Schedule")
                        .WithMany("Sensors")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("WaterLevelController.DAL.EfDbContext.Switch", "Switch")
                        .WithOne("Sensor")
                        .HasForeignKey("WaterLevelController.DAL.EfDbContext.Sensor", "SwitchId");

                    b.HasOne("WaterLevelController.DAL.EfDbContext.Zone", "Zone")
                        .WithMany("Sensors")
                        .HasForeignKey("ZoneId");
                });
#pragma warning restore 612, 618
        }
    }
}
