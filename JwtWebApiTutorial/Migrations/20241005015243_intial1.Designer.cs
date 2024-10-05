﻿// <auto-generated />
using System;
using JwtWebApiTutorial.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtWebApiTutorial.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241005015243_intial1")]
    partial class intial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JwtWebApiTutorial.Models.Citiy", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("CityTbl");

                    b.HasData(
                        new
                        {
                            CityId = new Guid("88d06f3e-a035-4cf2-9ebf-35114e27376f"),
                            CityName = "KNl"
                        },
                        new
                        {
                            CityId = new Guid("eb053846-2c65-430e-9526-2747d41f50b8"),
                            CityName = "knl"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}