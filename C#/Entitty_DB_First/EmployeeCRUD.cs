using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitty_DB_First
{
    internal class EmployeeCRUD
    {
        private readonly EmployeesEntities context;
        public EmployeeCRUD()
        {
            context = new EmployeesEntities();
        }
        public void AddEmployee(Employee employee)
        {
           var emp = context.Employees.Add(employee);
            if (emp != null)
            {
                context.SaveChanges();
                Console.WriteLine("---------------------Employee Added------------------");
            }

        }
        public void DeleteEmployee(int id)
        {
            var emp = context.Employees.Find(id);
            if(emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                Console.WriteLine("---------------------Employee Deleted------------------");
            }
        }
        public void UpdateEmployee(int id, Employee employee)
        {
            var emp = context.Employees.Find(id);
            if(emp != null)
            {
                emp = employee;
                context.SaveChanges();
                Console.WriteLine("-----------------------------Employee Updated-----------------");
            }

        }
        public void GetEmployees()
        {
            var employees = context.Employees.ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}; Name: {employee.Emp_Name}; Gender: {employee.Gender}; Age: {employee.Age}; Department: {employee.DepId}");
            }
        }
        public Employee GetEmployee(int Id)
        {
            var emp = context.Employees.Find(Id);
            return emp;
        }
        public void AddDepartment(Department department)
        {
            var dep = context.Departments.Add(department);
            if (dep != null)
            {
                context.SaveChanges();
            }
        }
    }
}
