using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Joins
{
    public enum Gender
    {
        Male,Female
    }
    public class Customer
    {
        public int Id { get; set; } 
        public string name { get; set; }
        public Gender gender { get; set; }
        public int age { get; set; }
        public string pincode { get; set; }
        public Customer()
        {
            
        }

        public Customer(int Id, string name , Gender gender, int age, string pincode)
        {
            this.Id = Id;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.pincode = pincode;
        }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {name}; Gender: {gender}; Age: {age}; Pincode: {pincode}";
        }
    }
}
