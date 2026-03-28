namespace Assignment06oop;

public abstract class Ticket
{
    private static int counter = 0;

    public int TicketId { get; }
    public string MovieName { get; set; }
    public decimal Price { get; set; }
    public bool IsBooked { get; private set; }

    protected Ticket(string movie, decimal price)
    {
        counter++;
        TicketId = counter;
        MovieName = movie;
        Price = price;
    }

    public void Book()
    {
        IsBooked = true;
    }

    public void Cancel()
    {
        IsBooked = false;
    }

    public abstract decimal CalculateFinalPrice();

    public virtual void Print()
    {
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
    }
}