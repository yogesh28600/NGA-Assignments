using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspEFCore.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please provide username")]
        [DisplayName("Username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please provide password")]
        [DisplayName("Password")]
        public string password { get; set; }
    }
}
