using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class Dependent : Person
    {
        public bool IsSpouse { get; set; }

        public int EmployeeId { get; set; }

        public Dependent(DependentDTO dep)
        {
            Id = dep.id;
            FirstName = dep.firstName;
            LastName = dep.lastName;
            BirthDate = dep.birthDate;
            IsSpouse = dep.isSpouse;
            EmployeeId = dep.employeeId;
        }
    }
}
