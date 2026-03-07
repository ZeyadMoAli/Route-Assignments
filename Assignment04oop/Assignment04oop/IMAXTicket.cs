namespace Assignment04oop;

public class IMAXTicket: Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movie, decimal price, bool is3D)
        : base(movie, price)
    {
        Is3D = is3D;
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        string text = Is3D ? "Yes" : "No";
        Console.WriteLine($"  IMAX 3D: {text}");
    }
}