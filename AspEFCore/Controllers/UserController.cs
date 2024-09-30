using AspEFCore.Context;
using AspEFCore.Repositories;
using AspEFCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspEFCore.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo userRepo;
        public UserController(IUserRepo repo)
        {
            userRepo =  repo;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = userRepo.GetUser(model.username);
            if (user != null && user.password == model.password)
            {
                return RedirectToRoute("List");
            }
            return Redirect("Login");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel user)
        {
            userRepo.AddUser(new Models.User()
            {
                username = user.username,
                password = user.password
            });
            return RedirectToAction("Login");
        }
        public IActionResult ValidateUsername(string username)
        {
            var user = userRepo.GetUser(username);
            if (user == null)
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}
