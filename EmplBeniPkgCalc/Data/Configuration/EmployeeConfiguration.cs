using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBenefitPackageCalc.src.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeBenefitPackageCalc.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "Gomez",
                    LastName = "Addams",
                    BirthDate = new DateTime(1964, 12, 18),
                    PayRate = 2000,
                    Insured = true,
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Parr",
                    BirthDate = new DateTime(1979, 8, 3),
                    PayRate = 2000,
                    Insured = true,
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Helen",
                    LastName = "Parr",
                    BirthDate = new DateTime(1980, 2, 25),
                    PayRate = 2000,
                    Insured = false,
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "April",
                    LastName = "O'Neil",
                    BirthDate = new DateTime(1984, 4, 4),
                    PayRate = 2000,
                    Insured = true,                    
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Sarah",
                    LastName = "Connor",
                    BirthDate = new DateTime(1981, 12, 27),
                    PayRate = 2000,
                    Insured = true,
                },
                new Employee
                {
                    Id = 6,
                    FirstName = "Agnarr",
                    LastName = "Runeardsson",
                    BirthDate = new DateTime(1977, 7, 7),
                    PayRate = 2000,
                    Insured = true,
                });
        }
    }
}
