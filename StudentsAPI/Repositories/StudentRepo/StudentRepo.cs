using StudentsAPI.Context;
using StudentsAPI.Models;

namespace StudentsAPI.Repositories.StudentRepo
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentDbContext _context;
        public StudentRepo(StudentDbContext context)
        {
            _context = context;
        }
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetStudents()
        {
           return _context.Students.ToList();
        }
    }
}
