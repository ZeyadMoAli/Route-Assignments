using EF01;

class Program
{
    static void Main()
    {
        using (var context = new BookStoreContext())
        {
            context.Database.EnsureCreated();

            Console.WriteLine("Database created successfully!");
        }
    }
}