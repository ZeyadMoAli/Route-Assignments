using Assignment01oop;

#region Q1

/*
A class is a reference type, while a struct is a value type.

Class objects are stored as references.

Structs store their own copy of data.
 */

#endregion

#region Q2
/*
public: accessible from anywhere.
private: accessible only inside the same class.
 */

#endregion

#region Q3


/*
Create a new project → Class Library.

Add classes and write reusable code.

Build the project.

Create another project (Console/Web App).

Right click → Add Reference → Project Reference.

Use the classes with using NamespaceName;.
 */

#endregion

#region Q4
/*
A class library is a project that contains reusable classes and methods compiled into a DLL.

Why we use it:

Code reuse.

Better project organization.

Easy maintenance.

Share functionality between multiple applications.
 */
#endregion


Console.Write("Enter Movie Name: ");
string movie = Console.ReadLine();

int typeInput;

while (true)
{
    Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");

    if (int.TryParse(Console.ReadLine(), out typeInput)
        && typeInput >= 0 && typeInput <= 2)
        break;

    Console.WriteLine("Invalid type. Enter 0, 1 or 2.");
}

TicketType type = (TicketType)typeInput;

char row;

while (true)
{
    Console.Write("Enter Seat Row (A,B,C...): ");

    string input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input) &&
        char.TryParse(input.ToUpper(), out row) &&
        char.IsLetter(row))
        break;

    Console.WriteLine("Invalid row. Enter a letter.");
}

int number;

while (true)
{
    Console.Write("Enter Seat Number: ");

    if (int.TryParse(Console.ReadLine(), out number)
        && number > 0)
        break;

    Console.WriteLine("Invalid seat number.");
}

SeatLocation seat = new SeatLocation(row, number);

double price;

while (true)
{
    Console.Write("Enter Price: ");

    if (double.TryParse(Console.ReadLine(), out price)
        && price > 0)
        break;

    Console.WriteLine("Invalid price.");
}

Ticket ticket =
new Ticket(movie, type, seat, price);

double discount;

while (true)
{
    Console.Write("Enter Discount Amount: ");

    if (double.TryParse(Console.ReadLine(), out discount)
        && discount >= 0)
        break;

    Console.WriteLine("Invalid discount.");
}



Console.WriteLine("\n===== Ticket Info =====");

ticket.PrintTicket();

double total = ticket.CalcTotal(14);

Console.WriteLine($"Total (14% tax) : {total:F2}");

Console.WriteLine("\n===== After Discount =====");

Console.WriteLine($"Discount Before : {discount:F2}");

ticket.ApplyDiscount(discount);

Console.WriteLine($"Discount After  : {discount:F2}");

ticket.PrintTicket();