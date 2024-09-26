using AspCoreWebApp.Models;
using AspCoreWebApp.Repositories.EmployeeRepo;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepo empRepo;
        public EmployeeController(IEmployeeRepo empRepo)
        {
            this.empRepo = empRepo;

        }
        public IActionResult Index()
        {
           var employees = empRepo.GetEmployees();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeModel employee)
        {
            bool res = empRepo.AddEmployee(employee);
            if (res)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }
        public IActionResult EditEmployee(int id)
        {
            var emp = empRepo.GetEmployee(id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel emp)
        {
            var res = empRepo.EditEmployee(emp);
            if (res)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("EditEmployee",emp.Id);
        }
        [HttpGet]
        public IActionResult DeleteEmployee(int id)
        {
            empRepo.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
