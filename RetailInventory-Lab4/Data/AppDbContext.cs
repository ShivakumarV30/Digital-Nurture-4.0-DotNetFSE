using Microsoft.EntityFrameworkCore;
using RetailDataInserter.Models;

namespace RetailDataInserter.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=RetailInsertDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
