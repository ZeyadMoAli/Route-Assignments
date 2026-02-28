namespace Assignment03oop;

public static class BookingHelper
{
    private static int counter = 0;

    public static decimal CalcGroupDiscount(int number, decimal pricePerTicket)
    {
        decimal total = number * pricePerTicket;

        if (number >= 5)
            total *= 0.9m;

        return total;
    }

    public static string GenerateBookingReference()
    {
        counter++;
        return $"BK-{counter}";
    }
}