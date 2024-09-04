using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Person
    {
        public string first_name {  get; set; }
        public string last_name { get; set;}
        public int age { get; set; }

        public Gender gender { get; set; }
        public double salary{ get; set; }

        public Person(string firstname, string lastname,int age,Gender gender, double salary)
        {
            this.first_name = firstname;
            this.last_name = lastname;
            this.age = age;
            this.gender = gender;
            this.salary = salary;
        }
        override
        public string ToString()
        {
            return $"first name: {this.first_name} last name: {this.last_name} age: {this.age} gender: {this.gender} Salary: {this.salary}";
        }

    }
}
