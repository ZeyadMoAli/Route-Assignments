namespace Assignment06oop;

public class StandardTicket: Ticket
{
    public string Seat { get; set; }

    public StandardTicket(string movie, decimal price, string seat)
        : base(movie, price)
    {
        Seat = seat;
    }

    public override decimal CalculateFinalPrice()
    {
        return Price * 1.14m;
    }

    public override void Print()
    {
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
    }
}