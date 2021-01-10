using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class Settings
    {
        public int id { get; set; }
        public string insuranceName { get; set; }
        public int employeeCost { get; set; }
        public int dependantCost { get; set; }
        public string discountString { get; set; }
        public int discountPercentage { get; set; }
    }
}
