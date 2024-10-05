using System.ComponentModel.DataAnnotations;

namespace AspEFCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public int age { get; set; }
        public DateTime dob { get; set; }
        public double bonus { get; set; }
        public double pay { get; set; }
    }
}
