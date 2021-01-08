using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeBenefitPackageCalc.src.Models;


namespace EmployeeBenefitPackageCalc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Dependant> Dependant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=ebp-calc;Integrated Security=True");
        }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName);
                entity.Property(e => e.BirthDate);
                entity.Property(e => e.PayRate);
                entity.Property(e => e.Insured);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.InsuranceName);
                entity.Property(e => e.EmployeeCost);
                entity.Property(e => e.DependantCost);
                entity.Property(e => e.DiscountString);
                entity.Property(e => e.DiscountPercentage);
            });

        }
    }
}
