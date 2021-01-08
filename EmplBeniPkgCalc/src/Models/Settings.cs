using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string InsuranceName { get; set; }
        public int EmployeeCost { get; set; }
        public int DependantCost { get; set; }
        public string DiscountString { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
