﻿// <auto-generated />
using System;
using AdvancedField.HashWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedField.HashWeb.Migrations
{
    [DbContext(typeof(MiddlewareDBContext))]
    partial class MiddlewareDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Core.DatabaseInfrastructure.FunTranslationResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EventCode")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EventTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EventType")
                        .HasColumnType("longtext");

                    b.Property<string>("IpAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Source")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FunTranslationResult");
                });
#pragma warning restore 612, 618
        }
    }
}
