using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Models;

namespace EmployeeAPI.Repository
{
   public  interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartements();
        Task<Department> GetDepartementByID(int ID);
        Task<Department> InsertDepartement(Department ObjDepartement);
        Task<Department> UpdateDepartement(Department ObjDepartement);
        bool DeleteDepartement(int ID);
    }
}
