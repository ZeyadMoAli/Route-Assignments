namespace Assignment02oop;

public static  class BookingHelper
{
    private static int counter = 0;

    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double total = numberOfTickets * pricePerTicket;

        if (numberOfTickets >= 5)
            total *= 0.9;

        return total;
    }

    public static string GenerateBookingReference()
    {
        counter++;
        return $"BK-{counter}";
    }
}