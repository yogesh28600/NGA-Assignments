using StudentsAPI.Models;

namespace StudentsAPI.Repositories.StudentRepo
{
    public interface IStudentRepo
    {
        public List<Student> GetStudents();
        public void AddStudent(Student student);
    }
}
