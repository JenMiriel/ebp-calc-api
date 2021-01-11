﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBenefitPackageCalc.src.Models;

namespace EmployeeBenefitPackageCalc.src.Models
{
    public class Employee : Person
    {
        public int PayRate { get; set; }
        public bool Insured { get; set; }

        public List<Dependent> Dependents { get; set; }

        public Employee(EmployeeDTO empl)
        {
            List<Dependent> dependentList = new List<Dependent>();
            foreach (DependentDTO dependent in empl.dependents)
            {
                dependentList.Add(new Dependent(dependent));
            }
            Id = empl.id;
            FirstName = empl.firstName;
            LastName = empl.lastName;
            BirthDate = empl.birthDate;
            PayRate = empl.payRate;
            Insured = empl.insured;
            Dependents = dependentList;
        }
    }
}
