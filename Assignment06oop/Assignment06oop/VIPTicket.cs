namespace Assignment06oop;

public class VIPTicket: Ticket
{
    public bool Lounge { get; set; }
    public decimal Fee { get; set; } = 50;

    public VIPTicket(string movie, decimal price, bool lounge)
        : base(movie, price)
    {
        Lounge = lounge;
    }

    public override decimal CalculateFinalPrice()
    {
        return (Price + Fee) * 1.14m;
    }

    public override void Print()
    {
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(Lounge ? "Yes" : "No")} | Fee: {Fee} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
    }
}