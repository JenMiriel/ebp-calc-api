﻿// <auto-generated />
using System;
using EmployeeBenefitPackageCalc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeBenefitPackageCalc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210110040830_AddSeedData")]
    partial class AddSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Dependant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSpouse")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Dependant");
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Insured")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PayRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DependantCost")
                        .HasColumnType("int");

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<string>("DiscountString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeCost")
                        .HasColumnType("int");

                    b.Property<string>("InsuranceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Dependant", b =>
                {
                    b.HasOne("EmployeeBenefitPackageCalc.src.Models.Employee", null)
                        .WithMany("Dependants")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Employee", b =>
                {
                    b.Navigation("Dependants");
                });
#pragma warning restore 612, 618
        }
    }
}
