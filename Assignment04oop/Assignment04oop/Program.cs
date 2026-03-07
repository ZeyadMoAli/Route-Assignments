using Assignment04oop;


#region Q1

/*
Static binding happens at compile time. 
The method call is decided by the compiler before the program runs
*/

/*
Dynamic binding happens at runtime.
The method that will execute is decided while the program is running depending on the object type.
 */

#endregion


#region Q2

/*
Method Overloading

Same method name.

Different parameters.

Happens in the same class.

It is resolved at compile time.


Method Overloading

Same method name.

Different parameters (number, type, or order).

Happens in the same class.

It is resolved at compile time.


 */



#endregion

#region Q3

/*
Keywords used in method overriding:

virtual
Used in the base class to allow a method to be overridden in child classes.

override
Used in the child class to provide a new implementation of a virtual method.

base
Used in the child class to call the parent class version of a method.
 */

#endregion

Cinema cinema = new Cinema();

cinema.OpenCinema();

Console.WriteLine("\n========== SetPrice Test ==========");

StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");
VIPTicket t2 = new VIPTicket("Avengers", 200, true);
IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

t1.SetPrice(150);
t1.SetPrice(100, 1.5m);

cinema.AddTicket(t1);
cinema.AddTicket(t2);
cinema.AddTicket(t3);

cinema.PrintAllTickets();

Console.WriteLine("\n========== Process Single Ticket ==========");
t2.PrintTicket();
cinema.CloseCinema();

