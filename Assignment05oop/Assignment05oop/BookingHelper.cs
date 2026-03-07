namespace Assignment05oop;

public static  class BookingHelper
{
    public static void PrintAll(IPrintable[] items)
    {
        Console.WriteLine("--- BookingHelper.PrintAll ---");

        foreach (var item in items)
        {
            item.Print();
        }
    }
}