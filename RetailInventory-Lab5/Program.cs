using Lab5DataRetriever.Data;
using Lab5DataRetriever.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// 1. Retrieve All Products
var products = await context.Products.ToListAsync();
Console.WriteLine("📦 All Products:");
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

Console.WriteLine();

// 2. Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"🔍 Found (ID=1): {product?.Name}");

Console.WriteLine();

// 3. FirstOrDefault with condition
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"💰 Expensive Product: {expensive?.Name}");
