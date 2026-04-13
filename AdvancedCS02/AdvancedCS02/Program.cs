

using AdvancedCS02;

public class Program
{
    public static void Main()
    {
        List<Product> catalog = new()
        {
            new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
        };

        Console.WriteLine("--- Electronics ---");
        var electronics = SearchProducts(catalog, p => p.Category == "Electronics");
        PrintList(electronics);

        Console.WriteLine("\n--- Under $50 ---");
        var cheap = SearchProducts(catalog, p => p.Price < 50);
        PrintList(cheap);

        Console.WriteLine("\n--- In Stock ---");
        var inStock = SearchProducts(catalog, p => p.Stock > 0);
        PrintList(inStock);

        Console.WriteLine("\n--- Clothing Under $100 ---");
        var clothing = SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
        PrintList(clothing);

        Console.WriteLine("\n--- Short Report ---");
        PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

        Console.WriteLine("\n--- Detailed Report ---");
        PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

        Console.WriteLine("\n--- Summary List ---");
        var summary = TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
        foreach (var s in summary)
            Console.WriteLine(s);

        Console.WriteLine("\n--- Price Labels ---");
        var labels = TransformProducts(catalog, p => p.Price > 100 ? "Expensive!" : "Affordable");
        for (int i = 0; i < catalog.Count; i++)
            Console.WriteLine($"{catalog[i].Name}: {labels[i]}");

        Console.WriteLine("\n--- Low-Stock Alert ---");
        var lowStock = FilterProducts(catalog, p => p.Stock < 20);
        foreach (var p in lowStock)
            Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
    }

    public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        List<Product> result = new();

        foreach (var p in products)
        {
            if (filter(p))
                result.Add(p);
        }

        return result;
    }

    public static void PrintReport(List<Product> products, Action<Product> action)
    {
        foreach (var p in products)
        {
            action(p);
        }
    }

    public static List<T> TransformProducts<T>(List<Product> products, Func<Product, T> transform)
    {
        List<T> result = new();

        foreach (var p in products)
        {
            result.Add(transform(p));
        }

        return result;
    }

    public static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
    {
        List<Product> result = new();

        foreach (var p in products)
        {
            if (condition(p))
                result.Add(p);
        }

        return result;
    }

    public static void PrintList(List<Product> list)
    {
        foreach (var p in list)
        {
            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }
    }
}