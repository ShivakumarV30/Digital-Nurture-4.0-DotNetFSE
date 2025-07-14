using Microsoft.EntityFrameworkCore;
using WebApi_Exercise4; 

namespace WebApi_Exercise4.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Saravana", Department = "IT", Salary = 50000 },
                new Employee { Id = 2, Name = "Kumar", Department = "HR", Salary = 45000 }
            );
        }
    }
}
