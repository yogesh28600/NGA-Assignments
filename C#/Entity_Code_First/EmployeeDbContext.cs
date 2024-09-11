using Entity_Code_First.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Code_First
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeDbContext>());
        }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Department> Departments { get; set;}
    }


}
