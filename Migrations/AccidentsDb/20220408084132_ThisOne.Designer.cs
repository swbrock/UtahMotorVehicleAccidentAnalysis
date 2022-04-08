﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Migrations.AccidentsDb
{
    [DbContext(typeof(AccidentsDbContext))]
    [Migration("20220408084132_ThisOne")]
    partial class ThisOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UtahMotorVehicleAccidentAnalysis.Models.Accident", b =>
                {
                    b.Property<string>("bicyclist_involved")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("city")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("commercial_motor_veh_involved")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("county_name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("crash_datetime")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("crash_id")
                        .HasColumnType("int");

                    b.Property<int>("crash_severity_id")
                        .HasColumnType("int");

                    b.Property<string>("distracted_driving")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("domestic_animal_related")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("drowsy_driving")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("dui")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("improper_restraint")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("intersection_related")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("lat_utm_y")
                        .HasColumnType("double");

                    b.Property<double>("long_utm_x")
                        .HasColumnType("double");

                    b.Property<string>("main_road_name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("milepoint")
                        .HasColumnType("double");

                    b.Property<string>("motorcycle_involved")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("night_dark_condition")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("older_driver_involved")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("overturn_rollover")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("pedestrian_involved")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("roadway_departure")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("route")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("single_vehicle")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("teenage_driver_involved")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("unrestrained")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("wild_animal_related")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("work_zone_related")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.ToTable("Accidents");
                });
#pragma warning restore 612, 618
        }
    }
}
