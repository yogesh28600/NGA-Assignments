﻿using AspEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspEFCore.Context
{
    public class EmployeeDbContext : DbContext 
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
