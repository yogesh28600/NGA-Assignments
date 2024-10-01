
using ASPWEBAPI.Context;
using ASPWEBAPI.Repositories.EmployeeRepo;
using Microsoft.EntityFrameworkCore;

namespace ASPWEBAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddXmlSerializerFormatters();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmpConn")));
            builder.Services.AddScoped<IEmployeeRepo,EmployeeRepo>();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins", builder => builder.WithOrigins("http://localhost:4200", "http://localhost:5043").AllowAnyHeader().AllowAnyMethod());
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
