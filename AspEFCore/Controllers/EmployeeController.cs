using AspEFCore.Context;
using AspEFCore.Repositories;
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
        [Route("employee/list",Name ="List")]
        public IActionResult Index()
        {
            var employees = _employeeRepo.GetEmployees();
            return View(employees);
        }
    }
}
