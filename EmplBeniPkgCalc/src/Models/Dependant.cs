using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class Dependant : Person
    {
        public bool IsSpouse { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
