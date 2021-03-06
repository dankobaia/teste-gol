﻿// <auto-generated />
using System;
using AirplaneCrud.Repository.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirplaneCrud.Repository.EF.Migrations
{
    [DbContext(typeof(AirplaneDbContext))]
    [Migration("20190404223431_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("AirplaneCrud.Repository.EF.Models.Airplane", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("MaxPassengers");

                    b.Property<string>("Model");

                    b.HasKey("Id");

                    b.ToTable("Airplanes");
                });
#pragma warning restore 612, 618
        }
    }
}
