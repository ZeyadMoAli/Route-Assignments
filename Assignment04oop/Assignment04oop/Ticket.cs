namespace Assignment04oop;

public abstract class Ticket
{
    
    private static int counter = 0;

    public int TicketId { get; }
    public string MovieName { get; set; }

    private decimal price;

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public decimal PriceAfterTax
    {
        get { return Price * 1.14m; }
    }

    protected Ticket(string movieName, decimal price)
    {
        counter++;
        TicketId = counter;
        MovieName = movieName;
        Price = price;
    }

    public virtual void PrintTicket()
    {
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
    }

    public void SetPrice(decimal newPrice)
    {
        Console.WriteLine($"Setting price directly: {newPrice}");
        Price = newPrice;
    }

    public void SetPrice(decimal basePrice, decimal multiplier)
    {
        decimal result = basePrice * multiplier;
        Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {result}");
        Price = result;
    }
}