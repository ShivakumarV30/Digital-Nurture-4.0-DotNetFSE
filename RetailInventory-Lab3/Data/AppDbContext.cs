using Microsoft.EntityFrameworkCore;
using RetailCLIApp.Models;

namespace RetailCLIApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RetailCLIDb;Trusted_Connection=True;");
    }
}
