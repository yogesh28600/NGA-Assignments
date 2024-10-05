using AspEFCore.Context;
using AspEFCore.Factory;
using AspEFCore.Models;
using AspEFCore.Repositories;
using AspEFCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspEFCore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeController(IEmployeeRepo empRepo)
        {
            _employeeRepo = empRepo;
        }
        public IActionResult Index()
        {
            var employees = _employeeRepo.GetEmployees();
            return View(employees);
        }
        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeViewModel employeeView)
        {
            EmployeeFactory employeeFactory = new EmployeeFactory();
            IEmployeeManager employeeManager = employeeFactory.GetEmployee(Convert.ToInt16(employeeView.emp_type));
            Employee emp = new Employee()
            {
                firstName = employeeView.firstName,
                middleName = employeeView.middleName,
                lastName = employeeView.lastName,
                email = employeeView.email,
                phoneNumber = employeeView.phoneNumber,
                address = employeeView.address,
                country = employeeView.country,
                age = employeeView.age,
                dob = employeeView.dob,
                bonus = employeeManager.GetBonus(),
                pay = employeeManager.GetPay()
            };
            _employeeRepo.AddEmployee(emp);
            return RedirectToAction("Index");
        }
    }
}
