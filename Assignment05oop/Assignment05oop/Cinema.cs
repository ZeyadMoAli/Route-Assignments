namespace Assignment05oop;

public class Cinema
{
    private Ticket[] tickets = new Ticket[20];
    private Projector projector = new Projector();

    public void OpenCinema()
    {
        Console.WriteLine("=== Cinema Opened ===");
        projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine("=== Cinema Closed ===");
        projector.Stop();
    }

    public void AddTicket(Ticket t)
    {
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                break;
            }
        }
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("--- All Tickets ---");

        foreach (var t in tickets)
        {
            if (t != null)
                t.Print();
        }
    }
}