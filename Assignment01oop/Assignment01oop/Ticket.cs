namespace Assignment01oop;

public class Ticket
{
    public string MovieName { get; set; }
    public TicketType TicketType { get; set; }
    public SeatLocation SeatLocation { get; set; }
    private double Price { get; set; }

    public Ticket(string movieName, TicketType ticketType, SeatLocation seatLocation, double price)
    {
        MovieName = movieName;
        TicketType = ticketType;
        SeatLocation = seatLocation;
        Price = price;
        
    }
    public Ticket(string movieName): this(movieName, TicketType.Standard, new SeatLocation('A',1),50)
    {
    }

    public double CalcTotal(double taxPercent)
    {
        return Price + (Price * taxPercent/100);
    }
    
    public void ApplyDiscount(double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price -=  discountAmount;
            discountAmount = 0;
        }
        
    }

    public void PrintTicket()
    {
        Console.WriteLine($"Movie    : {MovieName}");
        Console.WriteLine($"Type     : {TicketType}");
        Console.WriteLine($"Seat     : {SeatLocation}");
        Console.WriteLine($"Price    : {Price:F2}");
    }
}