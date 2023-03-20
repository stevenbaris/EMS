using EMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace EMS.Data
{
    public static class SeedData
    {
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, "Juan Dela Cruz", DateTime.Now.AddYears(-20),
                "juan@gmail.com", "09123456789" ,1, null),
                new Employee(2, "Maria Clara", DateTime.Now.AddYears(-20),
                "maria@gmail.com", "12345678912",2, null)
                );

            modelBuilder.Entity<Department>().HasData(
                new Department(1, "Human Resources"),
                new Department(2, "Information Technology"),
                new Department(3, "Finance"),
                new Department(4, "Marketing"),
                new Department(5, "Operations Management")
                );
        }
    }
}
