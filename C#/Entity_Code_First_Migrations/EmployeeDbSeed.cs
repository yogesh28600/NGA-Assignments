using Entity_Code_First.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Code_First
{
    public class EmployeeDbSeed : DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            Console.WriteLine("Seeding.................");
            context.Departments.Add(new Department() { Dep_Name = "HR" });
            context.Departments.Add(new Department() { Dep_Name = "IT" });
            context.Departments.Add(new Department() { Dep_Name = "PAYROLL" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
