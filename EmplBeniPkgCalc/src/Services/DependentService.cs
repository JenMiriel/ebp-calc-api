using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeBenefitPackageCalc.src.Models;
using EmployeeBenefitPackageCalc.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBenefitPackageCalc.Services
{
    public class DependentService
    {
        private AppDbContext _context;
        public DependentService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public DependentDTO GetSingleDependent(int id)
        {
            var dependent = _context.Dependant.Where(e => e.Id == id).ToList();
            DependentDTO dependentToReturn = new DependentDTO(dependent.First());
            return dependentToReturn;
        }

        public async Task UpdateDependent(int updateId, DependentDTO dependentDTO)
        {
            Dependent updateDependent = new Dependent(dependentDTO);

            _context.Update(updateDependent);
            await _context.SaveChangesAsync();
        }

        public async Task AddNewDependentAsync(DependentDTO newDependentDTO)
        {
            Dependent addNewDependent = new Dependent(newDependentDTO);

            _context.Add(addNewDependent);
            await _context.SaveChangesAsync();
        }

        public void DeleteDependent(int deleteId)
        {
            Dependent dependentToDelete = _context.Dependant.Where(a => a.Id == deleteId).FirstOrDefault();
            _context.Remove(dependentToDelete);
        }

    }
}
