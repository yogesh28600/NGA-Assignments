using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------Task 1------------------------------------------");
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                if (t != null)
                {
                    Console.WriteLine("Type: "+ t.Name);
                    Type[] interfaces = t.GetInterfaces();
                    if(interfaces.Length > 0)
                    {
                        foreach (Type intf in interfaces)
                        {
                            Console.WriteLine("Inherited interface: " + intf.Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Inherited Interfaces");
                    }

                   
                    Type basetype = t.BaseType;
                    if(basetype != null)
                    {
                        Console.WriteLine("Base Class: "+basetype.Name);
                    }
                   
                }
                Console.WriteLine("--------------------------------------------------------------------");
            }

            Console.WriteLine("----------------------------------Task 2------------------------------------------");
            Type type = assembly.GetType("Reflections.Employee");
            Console.WriteLine($"Type: {type.Name}");
            if(type != null)
            {
                object obj = Activator.CreateInstance(type);
                PropertyInfo empID = type.GetProperty("EmpId");
                PropertyInfo salary = type.GetProperty("Salary");
                PropertyInfo firstname = type.GetProperty ("Fullname");
                PropertyInfo address = type.GetProperty("Address");
                if (empID != null)
                {
                    empID.SetValue(obj, 101);
                    Console.WriteLine($"{empID.Name}: {empID.GetValue(obj)}");
                }
                if(firstname != null)
                {
                    firstname.SetValue(obj, "John");
                    Console.WriteLine($"{firstname.Name}: {firstname.GetValue(obj)}");
                }
                if(address != null)
                {
                    address.SetValue(obj, "USA");
                    Console.WriteLine($"{address.Name}: {address.GetValue(obj)}");
                }
                if(salary != null)
                {
                    salary.SetValue(obj, 20000);
                    Console.WriteLine($"{salary.Name}: {salary.GetValue(obj)}");
                }

            }

            Console.WriteLine("----------------------------------Task 3------------------------------------------");
            Type employee = assembly.GetType("Reflections.Employee");
            if(employee != null)
            {
                MethodInfo non_param_method = employee.GetMethod("work");
                Console.WriteLine($"Method: {non_param_method.Name}");
                Console.WriteLine($"No of Parameters: {non_param_method.GetParameters().Length}");
                object obj1 = Activator.CreateInstance(employee);
                if (non_param_method != null && obj1 != null)    
                {                   
                        non_param_method.Invoke(obj1, null);

                }
                MethodInfo param_method = employee.GetMethod("promote");
                if(param_method != null && obj1 != null)
                {
                    Console.WriteLine($"Method: {param_method.Name}");
                    Console.WriteLine($"No of Parameters: {param_method.GetParameters().Length}"); 
                    object[] param = new object[param_method.GetParameters().Length];
                    param[0] = "Senior Developer";
                    param_method.Invoke(obj1, param);
                }

            }
            

            Console.ReadLine();
        }
    }
}
