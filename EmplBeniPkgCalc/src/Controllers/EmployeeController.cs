using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeBenefitPackageCalc.Services;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Data;
using System.Text.Json.Serialization;

namespace EmployeeBenefitPackageCalc.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private AppDbContext _context;
        private EmployeeService _employeeService;

        public EmployeeController(AppDbContext context, EmployeeService employeeService)
        {
            _context = context;
            _employeeService = employeeService;
        }

        // GET: api/Employee
        [HttpGet]
        public JsonResult GetAllEmployees()
        {
            var result = _employeeService.GetAllEmployees();
            return new JsonResult(result);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "GetEmployee")]
        public EmployeeDTO GetOneEmployee(int id)
        {
            var result = _employeeService.GetSingleEmployeeWithDependents(id);
            return result;
        }

        // POST: api/Employee
        [HttpPost]
        public async Task AddNewEmployee([FromBody] EmployeeDTO value)
        {
            await _employeeService.AddNewEmployeeAsync(value);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public async Task UpdateEmployee(int id, [FromBody] EmployeeDTO value)
        {
            await _employeeService.UpdateEmployee(value.id, value);
        }

        // DELETE: api/Employee/delete/5
        [HttpDelete("delete/{id}")]
        public void DeleteEmployee(int id)
        {
            _employeeService.DeleteEmployee(id);
        }

        // GET: api/employee/dependents
        [HttpGet("dependents", Name = "GetAll")]
        public JsonResult GetAllEmployeesAndDependents()
        {
            var getEveryone = _employeeService.GetAllEmployeesAndTheirDependents();
            return new JsonResult(getEveryone);
        }
    }
}
