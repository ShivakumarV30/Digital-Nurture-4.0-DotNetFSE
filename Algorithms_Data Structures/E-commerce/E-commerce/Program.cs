using System;

namespace EcommercePlatform
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int productId, string productName, string category)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
        }
    }

    public class SearchService
    {
        public static Product LinearSearch(Product[] products, string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, string productName)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compare = products[mid].ProductName.CompareTo(productName);

                if (compare == 0)
                    return products[mid];
                else if (compare < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
    }

    class Program
    {
        static void Main()
        {
            Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Footwear"),
                new Product(3, "Phone", "Electronics"),
                new Product(4, "T-shirt", "Clothing"),
                new Product(5, "Headphones", "Electronics")
            };

            Console.WriteLine("Linear Search Result:");
            var found1 = SearchService.LinearSearch(products, "Phone");
            Console.WriteLine(found1 != null ? $"Found: {found1.ProductName} ({found1.Category})" : "Product not found");

            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            Console.WriteLine("\nBinary Search Result:");
            var found2 = SearchService.BinarySearch(products, "Phone");
            Console.WriteLine(found2 != null ? $"Found: {found2.ProductName} ({found2.Category})" : "Product not found");
        }
    }
}