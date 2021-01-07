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
        private ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<Employee> GetAllEmployees()
        {
            var getAllEmployees = _context.Employees.ToList();
            return getAllEmployees;
        }
    }
}
