
using Microsoft.EntityFrameworkCore;
using StudentsAPI.Context;
using StudentsAPI.Repositories.StudentRepo;

namespace StudentsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IStudentRepo, StudentRepo>();
            builder.Services.AddDbContext<StudentDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDB")));
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins", builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseCors("AllowSpecificOrigins");
            app.MapControllers();

            app.Run();
        }
    }
}
