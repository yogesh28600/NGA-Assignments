using ASPWEBAPI.Models;
using ASPWEBAPI.Repositories.EmployeeRepo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ASPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo empRepo;
        public EmployeeController(IEmployeeRepo empRepo)
        {
            this.empRepo = empRepo;
        }
        [HttpGet]
        [Route("/employees")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [EnableCors]
        public IActionResult Get()
        {
            var employees = empRepo.GetEmployees();
            if(employees.Count == 0)
            {
                return BadRequest();
            }
            return Ok(employees);
        }
        [HttpGet]
        [Route("/employee/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get(int id)
        {
            var emp = empRepo.GetEmployeeById(id);
            if(emp == null)
            {
                return BadRequest();
            }
            return Ok(emp);
        }
        [HttpPost]
        [Route("/employees")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddEmployee(Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee Details should not be empty");
            }
            var emp = empRepo.AddEmployee(employee);
            return Created("/employees",emp);
        }
    }
}
