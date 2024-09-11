using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Code_First.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Emp_Name {  get; set; }
        public string Gender {  get; set; }
        public int Age { get; set; }
        public double Salary {  get; set; }
        public Department Dep_Id { get; set; }

    }
}
