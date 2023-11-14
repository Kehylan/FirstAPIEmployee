using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Repository
{
    public  class APIDbContext : DbContext 
    {
         public APIDbContext (DbContextOptions<APIDbContext> options): base(options) { }
        public DbSet<Department> Departments
        {
            get;
            set;
        }
        public DbSet <Employee> Employees
        {
            get;
            set;
        }
    }
}