#region Q1

/*
Abstraction means hiding complex details and showing only the important behavior.
Encapsulation means protecting data and controlling access to it.

Difference:

Abstraction focuses on what the object does.
Encapsulation focuses on how the data is protected.

Example:
A car

Abstraction: You drive using steering wheel and pedals without knowing how the engine works.
Encapsulation: The engine parts are hidden and cannot be accessed directly.
 */

#endregion


#region Q2

/*
 Abstract Class vs Interface

Abstract class can have fields, interface cannot.
Abstract class can have constructors, interface cannot.
Abstract class supports access modifiers, interface members are public by default.
A class can inherit only one abstract class but can implement multiple interfaces.

When to use:

Use abstract class when classes share common logic and state.
Use interface when you need a contract that multiple unrelated classes can implement.
 */


#endregion


#region Q3

/*
 a)
No, you cannot create an object from Appliance because it is abstract.

b)

PowerConsumption() → abstract → must be implemented by child classes.
Status() → virtual → has default behavior but can be overridden.
Label() → concrete → fully implemented and shared.

Reason:

Some behavior must be forced (abstract).
Some behavior is optional to change (virtual).
Some behavior is common (concrete).

c)
It will return "Standby" because Toaster does not override Status() so it uses the base implementation.
 */

#endregion


#region Q4

/*
 a)
A partial class allows splitting one class into multiple files.
Used to organize large classes or separate concerns.

b)
A partial method is a method declared in one file and optionally implemented in another.

If implementation is deleted, the code still compiles because the compiler removes the method call.

c)
An extension method adds new functionality to an existing class without modifying it.

Rules:

Must be in a static class.
Must be static method.
First parameter uses this keyword.

d)

Output:

Log: result = 20
$20.00
 */

#endregion


using Assignment06oop;

void Main()
{
 Console.WriteLine("=== Cinema Opened ===");
 Console.WriteLine("Projector ON\n");

 // Ticket t = new Ticket("Test", 100); // ERROR

 StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
 VIPTicket t2 = new VIPTicket("Avengers", 200, true);
 IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

 t1.Book();
 t2.Book();
 t3.Book();

 Cinema cinema = new Cinema();
 cinema.AddTicket(t1);
 cinema.AddTicket(t2);
 cinema.AddTicket(t3);

 cinema.PrintAll();

 Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");
 Ticket[] arr = new Ticket[] { t1, t2, t3 };

 foreach (var t in arr)
 {
  Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
 }

 Console.WriteLine("\n--- Extension Method: Receipt ---");
 Console.WriteLine(t2.ToReceipt());

 Console.WriteLine("\n--- Extension Method: Total Revenue ---");
 Console.WriteLine($"Total Revenue: {arr.TotalRevenue():F2}");

 Console.WriteLine("\nProjector OFF");
 Console.WriteLine("=== Cinema Closed ===");
}