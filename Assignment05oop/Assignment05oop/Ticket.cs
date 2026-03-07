namespace Assignment05oop;

public abstract  class Ticket: IPrintable, IBookable, ICloneable
{
    private static int counter = 0;

    public int TicketId { get; }
    public string MovieName { get; set; }
    public decimal Price { get; set; }
    public decimal PriceAfterTax => Price * 1.14m;

    protected bool isBooked;

    protected Ticket(string movie, decimal price)
    {
        counter++;
        TicketId = counter;
        MovieName = movie;
        Price = price;
    }

    public bool Book()
    {
        if (isBooked) return false;
        isBooked = true;
        return true;
    }

    public bool Cancel()
    {
        if (!isBooked) return false;
        isBooked = false;
        return true;
    }

    public abstract void Print();

    public abstract object Clone();
}