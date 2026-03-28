namespace Assignment06oop;

public static class TicketExtensions
{
    public static string ToReceipt(this Ticket t)
    {
        return $"========== RECEIPT ==========\nMovie    : {t.MovieName}\nType     : {t.GetType().Name}\nPrice    : {t.Price}\nFinal    : {t.CalculateFinalPrice():F2}\nStatus   : {(t.IsBooked ? "Booked" : "Not Booked")}\n=============================";
    }

    public static decimal TotalRevenue(this Ticket[] tickets)
    {
        decimal total = 0;
        foreach (var t in tickets)
        {
            if (t != null)
                total += t.CalculateFinalPrice();
        }
        return total;
    }
}