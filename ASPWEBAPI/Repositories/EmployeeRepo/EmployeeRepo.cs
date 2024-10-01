using ASPWEBAPI.Context;
using ASPWEBAPI.Models;

namespace ASPWEBAPI.Repositories.EmployeeRepo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee emp)
        {
            if (emp != null)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
            }
            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = _context.Employees.Find(id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
