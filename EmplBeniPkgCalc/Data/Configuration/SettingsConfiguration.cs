using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBenefitPackageCalc.src.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeBenefitPackageCalc.Data.Configuration
{
    public class SettingsConfiguration : IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder.ToTable("Settings");
            builder.HasData(
                new Settings
                {
                    id = 1,
                    insuranceName = "Hyrule Health Network",
                    employeeCost = 1000,
                    dependantCost = 500,
                    discountString = "A",
                    discountPercentage = 10,
                });
        }
    }
}
