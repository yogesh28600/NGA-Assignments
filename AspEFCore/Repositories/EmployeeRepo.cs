using AspEFCore.Context;
using AspEFCore.Models;

namespace AspEFCore.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context)
        {
            this._context = context;
        }
        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
