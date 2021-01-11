using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class DependentDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public bool isSpouse { get; set; }

        public int employeeId { get; set; }

        public DependentDTO(int id, string fname, string lname, DateTime bdate, bool spouse, int eId)
        {
            this.id = id;
            firstName = fname;
            lastName = lname;
            birthDate = bdate;
            isSpouse = spouse;
            employeeId = eId;
        }

        public DependentDTO(Dependent dep)
        {
            id = dep.Id;
            firstName = dep.FirstName;
            lastName = dep.LastName;
            birthDate = dep.BirthDate;
            isSpouse = dep.IsSpouse;
            employeeId = dep.EmployeeId;
        }
    }
}
