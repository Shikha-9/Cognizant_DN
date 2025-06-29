using System;

public class Product
{
    public int ProductId { get; }
    public string ProductName { get; }
    public string Category { get; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString() =>
        $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
}

class Program
{
    static void Main()
    {
        var products = new[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(150, "Mobile", "Electronics"),
            new Product(120, "Watch", "Accessories"),
            new Product(180, "Bag", "Fashion"),
            new Product(205, "Shoes", "Fashion")
        };

        var resultLinear = LinearSearch(products, 150);
        Console.WriteLine(resultLinear != null ? $"Linear found: {resultLinear}" : "Linear: Not found");

        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
        var resultBinary = BinarySearch(products, 150);
        Console.WriteLine(resultBinary != null ? $"Binary found: {resultBinary}" : "Binary: Not found");
    }

    static Product LinearSearch(Product[] products, int id)
    {
        foreach (var p in products)
            if (p.ProductId == id) return p;
        return null;
    }

    static Product BinarySearch(Product[] products, int id)
    {
        int low = 0, high = products.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (products[mid].ProductId == id)
                return products[mid];
            if (products[mid].ProductId < id)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return null;
    }
}
