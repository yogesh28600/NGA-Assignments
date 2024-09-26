using AspCoreWebApp.Models;

namespace AspCoreWebApp.Repositories.EmployeeRepo
{
    public interface IEmployeeRepo
    {
        public bool AddEmployee(EmployeeModel emp);
        public List<EmployeeModel> GetEmployees();
        public EmployeeModel GetEmployee(int id);
        public bool EditEmployee(EmployeeModel emp);
        public bool DeleteEmployee(int id);
    }
}
