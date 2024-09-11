using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCRUD crud= new EmployeeCRUD();
            crud.AddDepartment(new Department() { name = "HR" });
            crud.AddDepartment(new Department() { name = "IT" });
            crud.AddDepartment(new Department() { name = "PAYROLL" });

            while (true)
            {
                Console.WriteLine("Choose from Below Options");
                Console.WriteLine("1:Add Employee 2:Update Employee 3:Delete Employee 4:Get Employees");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Enter Employee Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Employee Gender: ");
                        string gender = Console.ReadLine();
                        Console.Write("Enter Employee Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Salary: ");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Employee Department: ");
                        int depId = int.Parse(Console.ReadLine());
                        crud.AddEmployee(new Employee()
                        {
                            name = name,
                            gender = gender,
                            age = age,
                            salary = salary,
                            depId = depId,
                        });
                        break;
                    case 2:
                        Console.Write("Enter Employee Id to be Updated: ");
                        int empId = int.Parse(Console.ReadLine());
                        var employee = crud.GetEmployee(empId);
                        if (employee == null)
                        {
                            Console.WriteLine("No Employee with given Id");
                            break;
                        }
                        Console.WriteLine("Choose from Below Options");
                        Console.WriteLine("1:Update Name 2:Update Age 3:Update Gender 4:Update Salary 5:Update Department");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                Console.Write("Enter Name: ");
                                string emp_name = Console.ReadLine();
                                employee.name = emp_name;
                                crud.UpdateEmployee(empId, employee);
                                break;
                            case 2:
                                Console.Write("Enter Age: ");
                                int emp_age = int.Parse(Console.ReadLine());
                                employee.age = emp_age;
                                crud.UpdateEmployee(empId, employee);
                                break;
                            case 3:
                                Console.Write("Enter Gender: ");
                                string emp_gender = Console.ReadLine();
                                employee.gender = emp_gender;
                                crud.UpdateEmployee(empId, employee);
                                break;
                            case 4:
                                Console.Write("Enter Salary: ");
                                double emp_salary = Convert.ToDouble(Console.ReadLine());
                                employee.salary = emp_salary;
                                crud.UpdateEmployee(empId, employee);
                                break;
                            case 5:
                                Console.Write("Enter Department Id: ");
                                int dep_id = int.Parse(Console.ReadLine());
                                employee.depId = dep_id;
                                crud.UpdateEmployee(empId, employee);
                                break;
                        }
                        break;
                    case 3:
                        Console.Write("Enter Employee Id to be Deleted: ");
                        crud.DeleteEmployee(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        crud.GetEmployees();
                        break;
                }
            }

            
        }
    }
}
