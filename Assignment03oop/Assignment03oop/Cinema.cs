namespace Assignment03oop;

public class Cinema
{
    private Ticket[] tickets = new Ticket[20];

    private Projector projector = new Projector();

    public string CinemaName { get; set; }

    public Cinema(string name)
    {
        CinemaName = name;
    }

    public bool AddTicket(Ticket t)
    {
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return true;
            }
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("\n========== All Tickets ==========");

        foreach (var t in tickets)
        {
            if (t != null)
                Console.WriteLine(t);
        }

        Console.WriteLine("\n========== Statistics ==========");
        Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

        Console.WriteLine($"\nBooking Ref 1: {BookingHelper.GenerateBookingReference()}");
        Console.WriteLine($"Booking Ref 2: {BookingHelper.GenerateBookingReference()}");

        decimal discount = BookingHelper.CalcGroupDiscount(5, 100);

        Console.WriteLine($"\nGroup Discount (5 x 100 EGP): {discount} EGP (10% off)");
    }

    public void OpenCinema()
    {
        Console.WriteLine("========== Cinema Opened ==========");
        projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine("\n========== Cinema Closed ==========");
        projector.Stop();
    }
}