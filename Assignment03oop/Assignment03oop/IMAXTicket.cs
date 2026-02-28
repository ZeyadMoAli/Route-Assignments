namespace Assignment03oop;

public class IMAXTicket:Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movie, decimal price, bool is3D)
        : base(movie, is3D ? price + 30 : price)
    {
        Is3D = is3D;
    }

    public override string ToString()
    {
        string text = Is3D ? "Yes" : "No";

        return base.ToString() + $" | IMAX 3D: {text}";
    }

}