using Linq01;

class Program
{
    static void Main()
    {
        List<Product> ProductList = new List<Product>
        {
            new Product { ProductName="Chai", Category="Beverages", UnitPrice=18, UnitsInStock=39 },
            new Product { ProductName="Chang", Category="Beverages", UnitPrice=19, UnitsInStock=17 },
            new Product { ProductName="Aniseed Syrup", Category="Condiments", UnitPrice=10, UnitsInStock=13 },
            new Product { ProductName="Chef Anton", Category="Condiments", UnitPrice=22, UnitsInStock=0 },
            new Product { ProductName="Ikura", Category="Seafood", UnitPrice=31, UnitsInStock=20 },
            new Product { ProductName="Konbu", Category="Seafood", UnitPrice=6, UnitsInStock=24 }
        };

        // 1
        var seafood = ProductList.Where(p => p.Category == "Seafood");
        foreach (var p in seafood)
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

        // 2
        var names = ProductList.Select(p => p.ProductName);
        foreach (var n in names)
            Console.WriteLine(n);

        // 3
        var sorted = ProductList.OrderBy(p => p.UnitPrice);
        foreach (var p in sorted)
            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

        // 4
        var range = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
        foreach (var p in range)
            Console.WriteLine(p.ProductName);

        // 5
        var condiments = ProductList
            .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

        foreach (var p in condiments)
            Console.WriteLine(p.ProductName);

        // 6
        var anon = ProductList.Select(p => new
        {
            Name = p.ProductName,
            Price = p.UnitPrice,
            StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
        });

        foreach (var x in anon)
            Console.WriteLine($"{x.Name} - {x.Price} - {x.StockStatus}");

        // 7
        var indexed = ProductList.Select((p, i) => new { Index = i + 1, p.ProductName });
        foreach (var x in indexed)
            Console.WriteLine($"{x.Index}. {x.ProductName}");

        // 8
        var complexSort = ProductList
            .OrderBy(p => p.Category)
            .ThenByDescending(p => p.UnitPrice);

        foreach (var p in complexSort)
            Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");

        // 9
        var beverages = ProductList
            .Where(p => p.Category == "Beverages")
            .OrderByDescending(p => p.UnitsInStock);

        foreach (var p in beverages)
            Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

        // 10 (Query Syntax Example)
        var orders = new[]
        {
            new { CustomerID="A", OrderDate=new DateTime(1996,1,1)},
            new { CustomerID="B", OrderDate=new DateTime(1998,1,1)}
        };

        var q = from o in orders
                where o.OrderDate.Year >= 1997
                select new { o.CustomerID, o.OrderDate };

        foreach (var x in q)
            Console.WriteLine($"{x.CustomerID} - {x.OrderDate}");

        // 11
        var pos = ProductList.Select((p, i) => $"{i + 1} - {p.ProductName}");
        foreach (var x in pos)
            Console.WriteLine(x);

        // 12
        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        var sortedWords = Arr
            .OrderBy(w => w.Length)
            .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

        foreach (var w in sortedWords)
            Console.WriteLine(w);

        // 13
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var result = digits
            .Where(d => d.Length > 1 && d[1] == 'i')
            .Reverse();

        foreach (var d in result)
            Console.WriteLine(d);
    }
}