namespace Assignment03oop;

public class VIPTicket:Ticket
{
    public bool LoungeAccess { get; set; }

    public decimal ServiceFee { get; } = 50m;

    public VIPTicket(string movie, decimal price, bool lounge)
        : base(movie, price)
    {
        LoungeAccess = lounge;
    }

    public override string ToString()
    {
        string lounge = LoungeAccess ? "Yes" : "No";

        return base.ToString() +
               $" | Lounge: {lounge} | Service Fee: {ServiceFee} EGP";
    }
}