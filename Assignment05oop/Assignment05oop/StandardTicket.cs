namespace Assignment05oop;

public class StandardTicket: Ticket
{
    
    public string SeatNumber { get; set; }

    public StandardTicket(string movie, decimal price, string seat)
        : base(movie, price)
    {
        SeatNumber = seat;
    }

    public override void Print()
    {
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(isBooked ? "Yes" : "No")}");
    }

    public override object Clone()
    {
        return new StandardTicket(MovieName, Price, SeatNumber);
    }
}