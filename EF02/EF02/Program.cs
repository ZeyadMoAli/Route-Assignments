using EF02;

using var db = new AppDbContext();

db.Database.EnsureCreated();

Console.WriteLine("Database Created Successfully.");