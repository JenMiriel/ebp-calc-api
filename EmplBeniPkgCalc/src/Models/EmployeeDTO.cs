using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PayRate { get; set; }
        public bool Insured { get; set; }

        public List<DependentDTO> Dependents { get; set; }

        public EmployeeDTO(int id, string fname, string lname, DateTime bdate, int pay, bool insured, List<DependentDTO> depndts)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            PayRate = pay;
            Insured = insured;
            Dependents = depndts;
        }

        public EmployeeDTO(Employee empl)
        {
            List<DependentDTO> dependentList = new List<DependentDTO>();
            foreach(Dependent dep in empl.Dependents)
            {
                dependentList.Add(new DependentDTO(dep));
            }
            Id = empl.Id;
            FirstName = empl.FirstName;
            LastName = empl.LastName;
            BirthDate = empl.BirthDate;
            PayRate = empl.PayRate;
            Insured = empl.Insured;
            Dependents = dependentList;
        }
    }


    public class DependentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsSpouse { get; set; }

        public int EmployeeId { get; set; }

        public DependentDTO(int id, string fname, string lname, DateTime bdate, bool spouse, int eId)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            BirthDate = bdate;
            IsSpouse = spouse;
            EmployeeId = eId;
        }

        public DependentDTO(Dependent dep)
        {
            Id = dep.Id;
            FirstName = dep.FirstName;
            LastName = dep.LastName;
            BirthDate = dep.BirthDate;
            IsSpouse = dep.IsSpouse;
            EmployeeId = dep.EmployeeId;
        }
    }
}
