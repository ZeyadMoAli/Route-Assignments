using EF03and04.Entities;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var db = new BankDbContext();
        db.Database.Migrate();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Open Account");
            Console.WriteLine("3. Update Account Status");
            Console.WriteLine("4. Remove Account");
            Console.WriteLine("5. List Customers");
            Console.WriteLine("0. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddCustomer(db); break;
                case "2": OpenAccount(db); break;
                case "3": UpdateStatus(db); break;
                case "4": RemoveAccount(db); break;
                case "5": ListCustomers(db); break;
                case "0": return;
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }

    static void AddCustomer(BankDbContext db)
    {
        Console.Write("Name: ");
        var name = Console.ReadLine();

        var customer = new Customer
        {
            FullName = name,
            CustomerType = "Individual"
        };

        db.Customers.Add(customer);
        db.SaveChanges();
    }

    static void OpenAccount(BankDbContext db)
    {
        Console.Write("Account Number: ");
        var accNum = Console.ReadLine();

        var account = new Account
        {
            AccountNumber = accNum,
            OpeningDate = DateTime.Now,
            CurrentBalance = 0,
            BranchId = 1
        };

        db.Accounts.Add(account);
        db.SaveChanges();
    }

    static void UpdateStatus(BankDbContext db)
    {
        Console.Write("Account Id: ");
        int id = int.Parse(Console.ReadLine());

        var acc = db.CustomerAccounts.FirstOrDefault(x => x.AccountId == id);
        if (acc != null)
        {
            acc.AccountStatus = acc.AccountStatus == "Active" ? "Closed" : "Active";
            db.SaveChanges();
        }
    }

    static void RemoveAccount(BankDbContext db)
    {
        Console.Write("Account Id: ");
        int id = int.Parse(Console.ReadLine());

        var acc = db.CustomerAccounts.FirstOrDefault(x => x.AccountId == id);
        if (acc != null)
        {
            db.CustomerAccounts.Remove(acc);
            db.SaveChanges();
        }
    }

    static void ListCustomers(BankDbContext db)
    {
        var list = db.Customers
            .Select(c => new
            {
                c.FullName,
                Accounts = c.CustomerAccounts.Select(a => a.Account.AccountNumber)
            });

        foreach (var c in list)
        {
            Console.WriteLine(c.FullName);
            foreach (var acc in c.Accounts)
                Console.WriteLine("  - " + acc);
        }
    }
}