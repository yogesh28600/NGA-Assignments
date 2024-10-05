using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspEFCore.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [DisplayName("Middle Name")]
        public string middleName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [DisplayName("Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        [Length(10, 10, ErrorMessage = "Phone number shold contain 10 digits")]
        [DisplayName("Phone Number")]
        public string phoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        [DisplayName("Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please select address")]
        [DisplayName("Country")]
        public string country { get; set; }
        [Required(ErrorMessage = "Pleasse enter Age")]
        [Range(0, 100, ErrorMessage = "Age should be between 0 and 100")]
        [DisplayName("Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Pleasse enter Date of birth")]
        [DisplayName("Date of Birth")]
        public DateTime dob { get; set; }
        [Required(ErrorMessage = "Pleasse select Employee Type")]
        [DisplayName("Employee Type")]
        public Enums.EmployeeTypes emp_type { get; set; }
        [DisplayName("Employee Role")]
        public string Role { get; set; }
    }
}
