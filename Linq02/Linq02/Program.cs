using Linq02;

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product{ProductID=1, ProductName="Chai", Category="Beverages", UnitPrice=18, UnitsInStock=39},
            new Product{ProductID=2, ProductName="Chang", Category="Beverages", UnitPrice=19, UnitsInStock=17},
            new Product{ProductID=3, ProductName="Ikura", Category="Seafood", UnitPrice=31, UnitsInStock=20},
            new Product{ProductID=4, ProductName="Konbu", Category="Seafood", UnitPrice=6, UnitsInStock=0},
            new Product{ProductID=5, ProductName="Tofu", Category="Food", UnitPrice=23, UnitsInStock=10},
            new Product{ProductID=18, ProductName="Caviar", Category="Seafood", UnitPrice=500, UnitsInStock=5}
        };

        var customers = new List<Customer>
        {
            new Customer{CompanyName="A", Country="Germany", TotalOrderValue=1000},
            new Customer{CompanyName="B", Country="France", TotalOrderValue=500},
            new Customer{CompanyName="C", Country="Germany", TotalOrderValue=700}
        };

        // 1
        var top3 = products.OrderByDescending(p => p.UnitPrice).Take(3);

        // 2
        var page2 = products.Skip(5).Take(5);

        // 3
        var less25 = products.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

        // 4
        bool allSeafoodInStock = products
            .Where(p => p.Category == "Seafood")
            .All(p => p.UnitsInStock > 0);

        // 5
        int[] ids = { 3, 9, 13, 18 };
        bool contains9 = ids.Contains(9);

        // 6
        var group1 = products.GroupBy(p => p.Category);
        foreach (var g in group1)
            Console.WriteLine($"{g.Key}: {g.Count()}");

        // 7
        var group2 = products
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });

        // 8
        var moreThan3 = products
            .GroupBy(p => p.Category)
            .Where(g => g.Count() > 3)
            .Select(g => g.Key);

        // 9
        var q = from c in customers
                group c by c.Country into g
                select new
                {
                    Country = g.Key,
                    Count = g.Count(),
                    Total = g.Sum(x => x.TotalOrderValue)
                };

        // 10
        var totalStock = products.Sum(p => p.UnitsInStock);

        // 11
        var minPrice = products.Min(p => p.UnitPrice);
        var maxPrice = products.Max(p => p.UnitPrice);

        // 12
        var categories = products.Select(p => p.Category).Distinct();

        // 13
        int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        int[] setB = { 3, 6, 9, 12, 15, 13 };
        var diff = setA.Except(setB);

        // 14
        string[] list1 = { "Germany", "France", "UK", "Spain" };
        string[] list2 = { "france", "SPAIN", "Italy" };

        var countriesDiff = list1
            .Except(list2, StringComparer.OrdinalIgnoreCase);

        // 15
        var dict = products.ToDictionary(p => p.ProductID);
        if (dict.TryGetValue(18, out var prod))
            Console.WriteLine(prod.ProductName);

        // 16
        var firstOver50 = products.First(p => p.UnitPrice > 50);

        // 17
        var safe = products.FirstOrDefault(p => p.UnitPrice > 500);

        // 18
        var table7 = Enumerable.Range(1, 10)
            .Select(x => $"7 x {x} = {7 * x}");

        // 19
        var evens = Enumerable.Range(1, 30)
            .Where(x => x % 2 == 0);

        // 20
        var concat = products.Take(3).Select(p => p.ProductName)
            .Concat(customers.Take(3).Select(c => c.CompanyName));

        // 21
        var paired = products.Zip(customers,
            (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

        // Print some outputs
        Console.WriteLine("\nTop 3:");
        foreach (var p in top3)
            Console.WriteLine(p.ProductName);

        Console.WriteLine("\nMultiplication Table 7:");
        foreach (var x in table7)
            Console.WriteLine(x);

        Console.WriteLine("\nEven Numbers:");
        Console.WriteLine(string.Join(", ", evens));
    }
}