namespace Assignment03oop;

public class Ticket
{
    private static int counter = 0;

    public string MovieName { get; set; }

    private decimal price;

    public decimal Price
    {
        get => price;
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public int TicketId { get; }

    public decimal PriceAfterTax
    {
        get => Price * 1.14m;
    }

    protected Ticket(string movieName, decimal price)
    {
        counter++;
        TicketId = counter;
        MovieName = movieName;
        Price = price;
    }

    public static int GetTotalTickets()
    {
        return counter;
    }

    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }
}