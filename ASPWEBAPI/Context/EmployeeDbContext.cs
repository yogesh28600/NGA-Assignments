using ASPWEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPWEBAPI.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
