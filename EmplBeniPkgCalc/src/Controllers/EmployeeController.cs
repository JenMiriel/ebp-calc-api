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

namespace EmployeeBenefitPackageCalc.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Employee
        [HttpGet]
        public JsonResult Get()
        {
            // var result = _employeeService.GetAllEmployees();
            var getAllEmployees = _context.Employee.ToList();
            // return getAllEmployees;
            return new JsonResult(getAllEmployees);
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
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

        // GET: api/Employee
        [HttpGet("-dependants")]
        public JsonResult GetAll()
        {
            //var getEveryone = (from e in _context.Employee
            //                   join d in _context.Dependant where e.Id equals d.EmployeeId).ToList();


                var query = objEntities.Employee.Join(objEntities.Department, r => r.EmpId, p => p.EmpId, (r, p) => new { r.FirstName, r.LastName, p.DepartmentName });

            GridView1.DataSource = query;

            GridView1.DataBind();

            var getEveryone = _context.Employee.Join(_context.Dependant, e => e.Id, d => d.EmployeeId, (e, d) => new { })

            return new JsonResult(getEveryone);
        }
    }
}
