namespace Assignment06oop;

public class IMAXTicket: Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movie, decimal price, bool is3D)
        : base(movie, price)
    {
        Is3D = is3D;
    }

    public override decimal CalculateFinalPrice()
    {
        decimal basePrice = Is3D ? Price + 30 : Price;
        return basePrice * 1.14m;
    }

    public override void Print()
    {
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
    }
}