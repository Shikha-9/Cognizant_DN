using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> products = new List<string>
            {
                "iPhone 14",
                "Samsung Galaxy S22",
                "MacBook Pro",
                "Dell XPS 13",
                "Sony Headphones",
                "Apple Watch",
                "Samsung Smart TV",
                "HP Pavilion Laptop",
                "Canon DSLR Camera",
                "Logitech Mouse"
            };

            
            Console.Write("Enter product to search: ");
            string keyword = Console.ReadLine();

            
            var results = products
                .Where(p => p.ToLower().Contains(keyword.ToLower()))
                .ToList();

            if (results.Count > 0)
            {
                Console.WriteLine("\nMatching products:");
                foreach (var product in results)
                {
                    Console.WriteLine("- " + product);
                }
            }
            else
            {
                Console.WriteLine("\nNo matching products found.");
            }

            Console.ReadLine(); 
        }
    }
}
