namespace Assignment03oop;

public class StandardTicket: Ticket
{
    public string SeatNumber { get; set; }

    public StandardTicket(string movie, decimal price, string seat)
        : base(movie, price)
    {
        SeatNumber = seat;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Seat: {SeatNumber}";
    }
}
