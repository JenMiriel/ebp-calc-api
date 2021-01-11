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
        public JsonResult Get()
        {
            var result = _employeeService.GetAllEmployees();
            return new JsonResult(result);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public EmployeeDTO Get(int id)
        {
            var result = _employeeService.GetSingleEmployeeWithDependents(id);
            return result;
        }

        // POST: api/Employee
        [HttpPost]
        public async Task PostAsync([FromBody] EmployeeDTO value)
        {
            await _employeeService.AddNewEmployeeAsync(value);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public async Task PutAsync(int id, [FromBody] EmployeeDTO value)
        {
            await _employeeService.UpdateEmployee(value.id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }

        // GET: api/employee/dependents
        [HttpGet("dependents", Name = "GetAll")]
        public JsonResult GetAll()
        {
            var getEveryone = _employeeService.GetAllEmployeesAndTheirDependents();
            return new JsonResult(getEveryone);
        }
    }
}
