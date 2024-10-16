using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Models;
using StudentsAPI.Repositories.StudentRepo;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _repo;
        public StudentsController(IStudentRepo repo) 
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var students = _repo.GetStudents();
            if(students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            _repo.AddStudent(student);
            return CreatedAtAction(nameof(Add), student);
        }
    }
}
