using AspEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspEFCore.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please provide username")]
        [Remote("ValidateUsername","User",ErrorMessage ="Username already exists")]
        [DisplayName("Username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please provide password")]
        [DisplayName("Password")]
        public string password { get; set; }
        [Compare("password",ErrorMessage ="Password and Confirm Password didnot match")]
        [DisplayName("Confirm Password")]
        public string confirmPassword {  get; set; }
    }
}
