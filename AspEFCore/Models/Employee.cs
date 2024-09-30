using System.ComponentModel.DataAnnotations;

namespace AspEFCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        public string firstName { get; set; }
        public string middleName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string lastName { get; set; }
        [Range(5000, 1000000, ErrorMessage = "Salary should be between 5000 and 1000000")]
        public double salary { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        [Length(10, 10, ErrorMessage = "Phone number shold contain 10 digits")]
        public string phoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please select address")]
        public string country { get; set; }
        [Required(ErrorMessage = "Pleasse enter Age")]
        [Range(0, 100, ErrorMessage = "Age should be between 0 and 100")]
        public int age { get; set; }

        [Required(ErrorMessage = "Pleasse enter Date of birth")]
        public DateTime dob { get; set; }
    }
}
