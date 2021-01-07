using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeBenefitPackageCalc.src.Models;


namespace EmployeeBenefitPackageCalc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Dependant> Dependants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=ebp-calc;Integrated Security=True");
        }


    protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasIndex(e => new { e.FirstName, e.LastName, e.Insured, e.PayRate });
            // base.OnModelCreating(modelBuilder);
        }
    }
}
