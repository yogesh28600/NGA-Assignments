using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_SQL
{
    internal class Employees
    {
        private readonly EmployeeDBDataContext context;
        public Employees()
        {
            this.context = new EmployeeDBDataContext();
        }
        public void get_employees()
        {
            List<Employe> employes = context.Employes.ToList();
            foreach (var employee in employes)
            {
                Console.WriteLine($"Id: {employee.Id} Employee Name: {employee.EmployeName}; Age: {employee.Age}; Gender: {employee.Gender}; Salary: {employee.Salary} Department: {employee.DeptId}");
            }
        }
        public void Add_employee(Employe employe)
        {
            var employees = context.Employes;
            employees.InsertOnSubmit(employe);
            context.SubmitChanges();
            Console.WriteLine("Added Succesfully");
        }

        public void delete_employee(int Id)
        {
            var employees = context.Employes;
            var emp = employees.SingleOrDefault(x=>x.Id == Id);
            employees.DeleteOnSubmit(emp);
            context.SubmitChanges();
            Console.WriteLine("Deleted Successfully");
        }

        public void update_employee(int Id, string name = "",float salary=0, int Age=0,int DeptId=0,string gender="" )
        {
            var emp = context.Employes.Single(x => x.Id == Id);
            emp.EmployeName = name != null ? name : emp.EmployeName;
            emp.Age = Age != 0 ? Age : emp.Age;
            emp.Salary = salary != 0 ? salary : emp.Salary;
            emp.DeptId = DeptId != 0? DeptId:emp.DeptId;
            context.SubmitChanges();
            Console.WriteLine("Updated Succesfully");
        }
        public Employe get_employee(int Id)
        {
            return context.Employes.Single(x => x.Id == Id);
        }
    }
}
