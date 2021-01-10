using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBenefitPackageCalc.src.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeBenefitPackageCalc.Data.Configuration
{
    public class DependantConfiguration : IEntityTypeConfiguration<Dependent>
    {
        public void Configure(EntityTypeBuilder<Dependent> builder)
        {
            builder.ToTable("Dependent");
            builder.HasData(
                new Dependent
                {
                    Id = 1,
                    FirstName = "Morticia",
                    LastName = "Addams",
                    BirthDate = new DateTime(1964, 12, 18),
                    IsSpouse = true,
                    EmployeeId = 1
                },
                new Dependent
                {
                    Id = 2,
                    FirstName = "Wednesday",
                    LastName = "Addams",
                    BirthDate = new DateTime(2007, 5, 3),
                    IsSpouse = false,
                    EmployeeId = 1
                },
                new Dependent
                {
                    Id = 3,
                    FirstName = "Pugsley",
                    LastName = "Addams",
                    BirthDate = new DateTime(2009, 7, 29),
                    IsSpouse = false,
                    EmployeeId = 1
                },
                new Dependent
                {
                    Id = 4,
                    FirstName = "Grandmama",
                    LastName = "Addams",
                    BirthDate = new DateTime(1942, 1, 1),
                    IsSpouse = false,
                    EmployeeId = 1
                },
                new Dependent
                {
                    Id = 5,
                    FirstName = "Helen",
                    LastName = "Parr",
                    BirthDate = new DateTime(1980, 2, 25),
                    IsSpouse = true,
                    EmployeeId = 1
                },
                new Dependent
                {
                    FirstName = "Violet",
                    LastName = "Parr",
                    BirthDate = new DateTime(2005, 9, 9),
                    IsSpouse = false,
                    EmployeeId = 2
                },
                new Dependent
                {
                    FirstName = "Dash",
                    LastName = "Parr",
                    BirthDate = new DateTime(2011, 4, 30),
                    IsSpouse = false,
                    EmployeeId = 2
                },
                new Dependent
                {
                    FirstName = "Jack-Jack",
                    LastName = "Parr",
                    BirthDate = new DateTime(2019, 11, 4),
                    IsSpouse = false,
                    EmployeeId = 2
                },
                new Dependent
                {
                    FirstName = "John",
                    LastName = "Connor",
                    BirthDate = new DateTime(2006, 5, 14),
                    IsSpouse = false,
                    EmployeeId = 5
                },
                new Dependent
                {
                    FirstName = "Iduna",
                    LastName = "Runeardsson",
                    BirthDate = new DateTime(1977, 3, 31),
                    IsSpouse = true,
                    EmployeeId = 6
                },
                new Dependent
                {
                    FirstName = "Elsa",
                    LastName = "Runeardsson",
                    BirthDate = new DateTime(2010, 12, 12),
                    IsSpouse = false,
                    EmployeeId = 6
                },
                new Dependent
                {
                    FirstName = "Anna",
                    LastName = "Runeardsson",
                    BirthDate = new DateTime(2013, 6, 8),
                    IsSpouse = false,
                    EmployeeId = 6
                }
                );
        }
    }
}
