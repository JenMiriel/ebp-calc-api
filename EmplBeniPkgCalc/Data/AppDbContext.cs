using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Data.Configuration;

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
        public DbSet<Settings> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=ebp-calc;Integrated Security=True");
        }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new SettingsConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new DependantConfiguration());

        }
    }
}
