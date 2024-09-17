using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;

namespace WpfApp
{
    internal class EmployeeCRUD
    {
        private readonly EmployeeDbContext context;
        public EmployeeCRUD()
        {
            context = new EmployeeDbContext();
        }
        public bool AddEmployee(Employee employee)
        {
            var emp = context.Employees.Add(employee);
            if (emp != null)
            {
                context.SaveChanges();
                return true;
            }
            return false;

        }
        public bool DeleteEmployee(int id)
        {
            var emp = context.Employees.Find(id);
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateEmployee(int id, Employee employee)
        {
            var emp = context.Employees.Find(id);
            if (emp != null)
            {
                emp = employee;
                context.SaveChanges();
                return true;
            }
            return false;

        }
        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }
        public Employee GetEmployee(int Id)
        {
            var emp = context.Employees.Find(Id);
            return emp;
        }
    }
}
