

using Assignment05oop;

Cinema cinema = new Cinema();
cinema.OpenCinema();

StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
VIPTicket t2 = new VIPTicket("Avengers", 200, true);
IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

t1.Book();
t2.Book();
t3.Book();

cinema.AddTicket(t1);
cinema.AddTicket(t2);
cinema.AddTicket(t3);

cinema.PrintAllTickets();

Console.WriteLine("--- Clone Test ---");

VIPTicket clone = (VIPTicket)t2.Clone();
clone.MovieName = "Interstellar";

Console.Write("Original : ");
t2.Print();

Console.Write("Clone    : ");
clone.Print();

Console.WriteLine("--- After Cancellation ---");

t1.Cancel();
t1.Print();

BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

cinema.CloseCinema();

#region Q1

/*
An interface in C# is a contract that defines a set of methods or properties that a class must implement.


Benefits of interfaces:

Loose coupling – classes depend on contracts instead of specific implementations.

Multiple inheritance – a class can implement multiple interfaces.

Better testing and extensibility – easier to replace implementations .
 
*/

#endregion



#region Q2

/*

The problem is that both interfaces contain a method called Greet().
Currently the class implements one public Greet() method, so both interfaces use the same implementation. 
*/


 interface IEnglishSpeaker
{
    void Greet();
}

interface IArabicSpeaker
{
    void Greet();
}

class Translator : IEnglishSpeaker, IArabicSpeaker
{
    void IEnglishSpeaker.Greet()
    {
        Console.WriteLine("Hello");
    }

    void IArabicSpeaker.Greet()
    {
        Console.WriteLine("Ahlan");
    }
}

/*
 No, you cannot call translator.Greet() directly because the methods are explicitly implemented.
 */





#endregion


#region Q3

/*

A shallow copy copies the object but keeps references to the same nested objects.

A deep copy copies the object and also creates new copies of all referenced objects.

Use cases:

Shallow copy when the object only contains value types or shared references are acceptable.

Deep copy when you want a completely independent object.

Risk of shallow copy:
If the object contains reference-type fields, modifying the copied object may also modify the original because both objects point to the same reference.

 
*/


#endregion

#region Q4

/*
 Explanation:

ShallowCopy() uses MemberwiseClone(), which performs a shallow copy.
 */

/*
 Dev - Testing
QA - Testing
 */


#endregion



