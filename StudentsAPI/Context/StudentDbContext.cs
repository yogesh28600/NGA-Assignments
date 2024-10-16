using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models;

namespace StudentsAPI.Context
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
