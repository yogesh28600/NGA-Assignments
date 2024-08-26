using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Graph
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public class Employee
    {
        public string name;
        public Gender gender;
        public string contactNo;
        public Employee(string name, Gender gender, string contactNo)
        {
            
            this.name = name;
            this.gender = gender;
            this.contactNo = contactNo;
        }

        override
         public string ToString()
        {
            return "{ " + this.name + "; " + this.gender + "; " + this.contactNo + " }";
        }
    }
}
