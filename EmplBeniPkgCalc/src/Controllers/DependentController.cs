using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Services;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBenefitPackageCalc.src.Controllers
{
    [Route("api/dependent")]
    [ApiController]
    public class DependentController : ControllerBase
    {
        private AppDbContext _context;
        private DependentService _dependentService;

        // GET: api/dependent
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/dependent/5
        [HttpGet("{id}", Name = "GetDependent")]
        public DependentDTO GetOneDependent(int id)
        {
            var result = _dependentService.GetSingleDependent(id);
            return result;
        }

        // POST: api/dependent
        [HttpPost]
        public async Task AddNewDependent([FromBody] DependentDTO value)
        {
            await _dependentService.AddNewDependentAsync(value);
        }

        // PUT: api/dependent/5
        [HttpPut("{id}", Name = "UpdateDependent")]
        public async Task UpdateExistingDependent(int id, [FromBody] DependentDTO value)
        {
            await _dependentService.UpdateDependent(value.id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteDependent")]
        public void DeleteDependent(int id)
        {
            _dependentService.DeleteDependent(id);
        }
    }
}
