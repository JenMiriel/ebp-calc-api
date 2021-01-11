using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBenefitPackageCalc.Services
{
    public class EmployeeService
    {
        private AppDbContext _context;
        public EmployeeService(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<Employee> GetAllEmployees()
        {
            var getAllEmployees = _context.Employee.ToList();
            return getAllEmployees;
        }

        public EmployeeDTO GetSingleEmployeeWithDependents(int id)
        {
            var employee = _context.Employee.Where(e => e.Id == id)
                                           .Include(dep => dep.Dependents).ToList();
            EmployeeDTO employeeToReturn = new EmployeeDTO(employee.First());
            return employeeToReturn;
        }

        public List<EmployeeDTO> GetAllEmployeesAndTheirDependents()
        {
            // this gives me a JSon circular error, which nobody seems to agree how to fix as of late 2020
            //var getEveryone = _context.Employee.Include(empl => empl.dependents).ToList();

            // so I'm doing this the brute force way, to get the mvp done, and will refactor when I find answers later
            List<EmployeeDTO> getEveryone = new List<EmployeeDTO>();
            List<DependentDTO> employeesDependents = new List<DependentDTO>();

            var getEmployees = _context.Employee.ToList();
            foreach (Employee empl in getEmployees)
            {
                List<Dependent> dependents = new List<Dependent>();
                dependents = _context.Dependant.Where(d => d.EmployeeId == empl.Id).ToList();
                foreach (Dependent dep in dependents)
                {
                    var newDepnd = new DependentDTO(dep.Id, dep.FirstName, dep.LastName, dep.BirthDate, dep.IsSpouse, dep.EmployeeId);
                    employeesDependents.Add(newDepnd);
                }
                var newEmpl = new EmployeeDTO(empl.Id, empl.FirstName, empl.LastName, empl.BirthDate, empl.PayRate, empl.Insured, employeesDependents);
                getEveryone.Add(newEmpl);
                employeesDependents = new List<DependentDTO>();
            }

            //List<EmployeeDTO> getEveryone = _context.Employee.Select(x => new { x.firstName, x.id, x.birthDate, x.insured, x.lastName, x.payRate, dependents = x.dependents.Select(x => new { x.birthDate, x.lastName }).ToList() }).ToList();

            return getEveryone;
        }
    }
}
