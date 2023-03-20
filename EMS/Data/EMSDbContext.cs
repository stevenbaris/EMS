using EMS.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.Data
{
    public class EMSDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Database Connectivity
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EMSDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api customize the tables schema
            //modelBuilder.UserModel();
            
            // seed some basic data 
            // administrator user in the user table
            modelBuilder.Entity<Employee>()
            .HasOne<Department>(me => me.Department)
            .WithMany(parent => parent.Employees)
            .HasForeignKey(me => me.DepartmentId);

            modelBuilder.SeedDefaultData();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }  
    }
}
