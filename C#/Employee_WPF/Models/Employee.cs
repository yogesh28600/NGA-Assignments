
using System.ComponentModel.DataAnnotations;

namespace WpfApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string middle_name { get; set;}
        [Required]
        public string last_name { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string dob {  get; set; }

    }
}
