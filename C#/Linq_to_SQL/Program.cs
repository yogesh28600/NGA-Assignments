using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Enter Choice: \n 1:Get Employees 2:Add Employee 3:Update Employee 4:Delete Employee");
                int choice = int.Parse(Console.ReadLine());
                Employees employee = new Employees();
                switch (choice)
                {
                    case 1:
                        employee.get_employees();
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee Name");
                        string EmployeeName = Console.ReadLine();
                        Console.WriteLine("Enter Gender");
                        string Gender = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        int Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Salary");
                        float Salary = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Department Id");
                        int DeptId = int.Parse(Console.ReadLine());
                        Employe employe = new Employe()
                        {
                            EmployeName = EmployeeName,
                            Age = Age,
                            Gender = Gender,
                            Salary = Salary,
                            DeptId = DeptId,
                        };
                        employee.Add_employee(employe);
                        break;
                    case 3:
                        Console.WriteLine("Enter Id to be updated");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("1:Employee Name 2:Gender 3:Age 4:Salary 5:Department");
                        int upd_choice = int.Parse(Console.ReadLine());
                        switch (upd_choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Employee Name");
                                string Name = Console.ReadLine();;
                                employee.update_employee(Id, name:Name);
                                break;
                            case 2:
                                Console.WriteLine("Enter Gender");
                                string emp_gender = Console.ReadLine();
                                employee.update_employee(Id, gender:emp_gender);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Id to be DELETED");
                        int del_id = int.Parse(Console.ReadLine());
                        employee.delete_employee(del_id);
                        break;

                }
            }

        }
    }
}
