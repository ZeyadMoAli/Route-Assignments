using Assignment02oop;



#region Q1
/*
a)Owner and Balance are public fields, so any external code can change them directly without validation.
Withdraw allows subtracting any value without checking balance or negative amounts.

b)Make fields private and expose them using properties with validation. Prevent invalid withdrawals by checking amount and available balance before updating it.

c)Public fields break encapsulation because any code can modify data directly, which may cause invalid states, security problems, and makes future changes harder.
*/
#endregion


#region Q2

/*
A field is a variable that stores data directly inside a class.
A property provides controlled access to a field using get and set.

Yes, a property can contain logic.
 */


#endregion


#region Q3
/*
a)this[int index] is called an Indexer. It allows objects of the class to be accessed like an array.

b)register[10] = "Ali"; throws IndexOutOfRangeException.
Safer version:

public string this[int index]
{
    get
    {
        if (index < 0 || index >= names.Length)
            return null;
        return names[index];
    }
    set
    {
        if (index >= 0 && index < names.Length)
            names[index] = value;
    }
}

c)
Yes. A class can have multiple indexers with different parameter types.

public string this[string name]
{
    get { return names.FirstOrDefault(n => n == name); }
}
*/


#endregion


#region Q4

/*
 a)
static means TotalOrders belongs to the class itself, not individual objects. All objects share the same value.

Item belongs to each object separately.

b)
No. Static methods cannot directly access instance fields because they do not belong to a specific object instance.
 */

#endregion


Cinema cinema = new Cinema();

Console.WriteLine("========== Ticket Booking ==========");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\nEnter data for Ticket {i + 1}:");

    Console.Write("Movie Name: ");
    string movie = Console.ReadLine();

    Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
    TicketType type = (TicketType)int.Parse(Console.ReadLine());

    Console.Write("Seat Row (A-Z): ");
    char row = char.Parse(Console.ReadLine());

    Console.Write("Seat Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    SeatLocation seat = new SeatLocation(row, number);

    Ticket ticket = new Ticket(movie, type, seat, price);

    cinema.AddTicket(ticket);
}

Console.WriteLine("\n========== All Tickets ==========");

for (int i = 0; i < 3; i++)
{
    var t = cinema[i];

    if (t != null)
    {
        Console.WriteLine(
            $"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax} EGP");
    }
}

Console.WriteLine("\n========== Search by Movie ==========");

Console.Write("Enter movie name to search: ");
string search = Console.ReadLine();

var found = cinema.GetMovie(search);

if (found != null)
{
    Console.WriteLine(
        $"Found: Ticket #{found.TicketId} | {found.MovieName} | {found.Type} | Seat: {found.Seat} | Price: {found.Price} EGP");
}
else
{
    Console.WriteLine("Movie not found");
}

Console.WriteLine("\n========== Statistics ==========");

Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

Console.WriteLine($"\nBooking Reference 1: {BookingHelper.GenerateBookingReference()}");
Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

double discount = BookingHelper.CalcGroupDiscount(5, 80);

Console.WriteLine($"\nGroup Discount (5 tickets x 80 EGP): {discount} EGP (10% off applied)");

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area
    {
        get { return Width * Height; }
    }
}
