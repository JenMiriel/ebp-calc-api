using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public int payRate { get; set; }
        public bool insured { get; set; }

        public List<DependentDTO> Dependents { get; set; }

        public EmployeeDTO(int id, string fname, string lname, DateTime bdate, int pay, bool insured, List<DependentDTO> depndts)
        {
            this.id = id;
            firstName = fname;
            lastName = lname;
            birthDate = bdate;
            payRate = pay;
            this.insured = insured;
            Dependents = depndts;
        }

        public EmployeeDTO(Employee empl)
        {
            List<DependentDTO> dependentList = new List<DependentDTO>();
            foreach(Dependent dep in empl.Dependents)
            {
                dependentList.Add(new DependentDTO(dep));
            }
            id = empl.Id;
            firstName = empl.FirstName;
            lastName = empl.LastName;
            birthDate = empl.BirthDate;
            payRate = empl.PayRate;
            insured = empl.Insured;
            Dependents = dependentList;
        }
    }


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
