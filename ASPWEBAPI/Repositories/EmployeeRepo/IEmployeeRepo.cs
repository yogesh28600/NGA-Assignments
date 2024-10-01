using ASPWEBAPI.Models;

namespace ASPWEBAPI.Repositories.EmployeeRepo
{
    public interface IEmployeeRepo
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployeeById(int id);
        public Employee AddEmployee(Employee emp);
    }
}
