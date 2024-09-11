using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Employee
    {
        public int Id { get; set; }
        public string name {  get; set; }
        public  string gender { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        public int depId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {name}; Gender: {gender}; Age: {age}; Salary: {salary}; Dep Id: {depId};";
        }
    }
}
