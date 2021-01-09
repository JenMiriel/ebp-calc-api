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
                    Id = 1,
                    InsuranceName = "Hyrule Health Network",
                    EmployeeCost = 1000,
                    DependantCost = 500,
                    DiscountString = "A",
                    DiscountPercentage = 10,
                });
        }
    }
}
