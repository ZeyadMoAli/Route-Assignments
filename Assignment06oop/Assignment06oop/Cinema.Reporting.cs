namespace Assignment06oop;

public partial class Cinema
{
    public void PrintAll()
    {
        Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");
        foreach (var t in tickets)
        {
            if (t != null)
                t.Print();
        }
    }
}