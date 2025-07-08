using Microsoft.EntityFrameworkCore;
using Lab5DataRetriever.Models;

namespace Lab5DataRetriever.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost\\SQLEXPRESS;Database=Lab5Db;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
