using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class Employee : Person
    {
        public int PayRate { get; set; }
        public bool Insured { get; set; }

        public ICollection<Dependent> Dependents { get; set; }
    }
}
