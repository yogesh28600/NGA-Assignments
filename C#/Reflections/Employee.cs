using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public class Employee :Person,IManager,IEmployee
    {
        public int EmpId { get; set; }
        public double Salary { get; set; }

        public void promote(string position)
        {
            Console.WriteLine("Employee is promoted as "+ position);
        }

        public void work()
        {
            Console.WriteLine("Employee is working");
        }
    }
}
