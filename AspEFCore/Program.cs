using AspEFCore.Context;
using AspEFCore.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspEFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<EmployeeDbContext>(options=>options
            .UseSqlServer(builder.Configuration.GetConnectionString("EmpConn")));
            builder.Services.AddDbContext<UserDbContext>(options => options
            .UseSqlServer(builder.Configuration.GetConnectionString("UserConn")));
            builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            builder.Services.AddScoped<IUserRepo, UserRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
