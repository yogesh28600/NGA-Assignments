using AspEFCore.Models;

namespace AspEFCore.Repositories
{
    public interface IEmployeeRepo
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(int id);
        public void AddEmployee(Employee employee);
    }
}
