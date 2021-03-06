﻿// <auto-generated />
using System;
using EmployeeBenefitPackageCalc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeBenefitPackageCalc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Dependent", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isSpouse")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("employeeId");

                    b.ToTable("Dependent");
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("insured")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("payRate")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Settings", b =>
                {
                    b.Property<int>("id")
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

                    b.HasKey("id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("EmployeeBenefitPackageCalc.src.Models.Dependent", b =>
                {
                    b.HasOne("EmployeeBenefitPackageCalc.src.Models.Employee", null)
                        .WithMany("Dependants")
                        .HasForeignKey("employeeId")
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
