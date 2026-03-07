namespace Assignment04oop;

public class VIPTicket: Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; } = 50;

    public VIPTicket(string movie, decimal price, bool lounge)
        : base(movie, price)
    {
        LoungeAccess = lounge;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        string lounge = LoungeAccess ? "Yes" : "No";
        Console.WriteLine($"  Lounge: {lounge} | Service Fee: {ServiceFee} EGP");
    }
}