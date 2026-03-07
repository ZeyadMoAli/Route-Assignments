namespace Assignment05oop;

public class IMAXTicket: Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movie, decimal price, bool is3D)
        : base(movie, price)
    {
        Is3D = is3D;
    }

    public override void Print()
    {
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(isBooked ? "Yes" : "No")}");
    }

    public override object Clone()
    {
        return new IMAXTicket(MovieName, Price, Is3D);
    }
}