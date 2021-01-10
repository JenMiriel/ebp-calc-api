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
        public Employee Get(int id)
        {
            var employee = _context.Employee.Single(e => e.Id == id);
            return employee;
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/employee/dependents
        [HttpGet("dependents", Name = "GetAll")]
        public JsonResult GetAll()
        {
            // this gives me a JSon circular error, which nobody seems to agree how to fix as of late 2020
            //var getEveryone = _context.Employee.Include(empl => empl.Dependents).ToList();

            // so I'm doing this the brute force way, to get the mvp done, and will refactor when I find answers later
            var getEveryone = _context.Employee.ToList();
            foreach (Employee empl in getEveryone)
            {
                var getAttachedDependents = _context.Dependant.Where(d => d.EmployeeId == empl.Id).ToList();
                empl.Dependents = getAttachedDependents;
            }
            return new JsonResult(getEveryone);
        }
    }
}
