using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Models;
using EmployeeAPI.Repository;
namespace EmployeeAPI.Repository
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly APIDbContext  _appIDbContext;
        public DepartmentRepository (APIDbContext context)
        {
           _appIDbContext = context;
            throw new ArgumentNullException(nameof(context));
        }
        public async Task <IEnumerable<Department>> GetDepartements()
        {
            return await _appIDbContext.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartementByID(int ID)
        {
            return await _appIDbContext.Departments.FindAsync(ID);
        }
        public async Task<Department> InsertDepartement(Department objDepartement)
        {
            _appIDbContext.Departments.Add(objDepartement);
            await _appIDbContext.SaveChangesAsync();
            return objDepartement;
        }

        public async Task<Department> UpdateDepartement(Department objDepartement)
        {
            _appIDbContext.Entry(objDepartement).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _appIDbContext.SaveChangesAsync();
            return objDepartement;
        }

        public bool DeleteDepartement(int ID)
        {
            bool result = false;
            var departement = _appIDbContext.Departments.Find(ID);
            if(departement != null)
            {
                _appIDbContext.Entry(departement).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _appIDbContext.SaveChanges();
                result = true;
            }
            else
            {
                throw new NotImplementedException();
            }
            return result;
        }

     
    }
}
