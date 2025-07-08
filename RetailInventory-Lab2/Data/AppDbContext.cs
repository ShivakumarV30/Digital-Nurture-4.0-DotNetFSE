// File: Data/AppDbContext.cs

using Microsoft.EntityFrameworkCore;
using RetailInventoryLab.Models;

namespace RetailInventoryLab.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=RetailStoreDb;Trusted_Connection=True;");
    }
}
