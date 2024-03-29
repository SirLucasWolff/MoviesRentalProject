﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesRental.Infra.ORM;

#nullable disable

namespace MoviesRental.Infra.ORM.Migrations
{
    [DbContext(typeof(MoviesRentalDbContext))]
    [Migration("20230530201515_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MoviesRental.Domain.ClientModule.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<DateTime?>("BornDate")
                        .HasColumnType("DATE");

                    b.Property<string>("ClientName")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Telephone")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.ToTable("ClientDB", (string)null);
                });

            modelBuilder.Entity("MoviesRental.Domain.EmployeeModule.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccessKey")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Password")
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeDB", (string)null);
                });

            modelBuilder.Entity("MoviesRental.Domain.MovieModule.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Availability")
                        .HasColumnType("BIT");

                    b.Property<string>("AvailabilityMessage")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Category")
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<string>("Classification")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("DATE");

                    b.HasKey("Id");

                    b.ToTable("MovieDB", (string)null);
                });

            modelBuilder.Entity("MoviesRental.Domain.RentModule.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClientName")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("DayValue")
                        .HasColumnType("INT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<int>("MovieValue")
                        .HasColumnType("INT");

                    b.Property<int?>("MoviesQuantity")
                        .HasColumnType("INT");

                    b.Property<DateTime?>("RentalDate")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("DATE");

                    b.Property<string>("Status")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<byte[]>("StatusImage")
                        .IsRequired()
                        .HasColumnType("IMAGE");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.ToTable("RentDB", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
