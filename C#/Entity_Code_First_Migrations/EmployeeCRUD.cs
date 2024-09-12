using Entity_Code_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Code_First
{
    public class EmployeeCRUD
    {
        private readonly EmployeeDbContext context;
        public EmployeeCRUD()
        {
            context = new EmployeeDbContext();
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
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                Console.WriteLine("---------------------Employee Deleted------------------");
            }
        }
        public void UpdateEmployee(int id, Employee employee)
        {
            var emp = context.Employees.Find(id);
            if (emp != null)
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
                int depId = employee.Dep_Id != null ? employee.Dep_Id.Id : 0;
                Console.WriteLine($"ID: {employee.Id}; Name: {employee.Emp_Name}; Gender: {employee.Gender}; Age: {employee.Age}; Department: {depId}");
            }
        }
        public Employee GetEmployee(int Id)
        {
            var emp = context.Employees.Find(Id);
            return emp;
        }
        public void AddDepartment(Department dep)
        {
            var add_dep = context.Departments.Add(dep);
            if (add_dep != null)
            {
                context.SaveChanges();
            }
        }
        public Department GetDepartment(int Id)
        {
            var dep = context.Departments.Find(Id);
            if(dep != null)
            {
                return dep;
            }
            return null;
        }
        public void GetDepartments()
        {
            var departments = context.Departments.ToList();
            foreach(var department in departments)
            {
                Console.WriteLine(department.Dep_Name);
            }
        }
    }
}
