#region Q1

/*
 a) Composition — Departments depend completely on the University’s existence.

b) Association — Driver uses a Car but does not own it.

c) Inheritance — Dog is a type of Animal.

d) Aggregation — Players exist independently from the Team.

e) Dependency — Logger is used temporarily inside a method.
 */

#endregion

#region Q2

/*
 a)
Yes, a child class in another assembly can access a protected field through inheritance.
No, it cannot access it through an object instance from outside the class hierarchy.

b)

protected internal → accessible from derived classes OR any class in the same assembly.

private protected → accessible only inside derived classes AND only within the same assembly.

c)

Sealed class → cannot be inherited.

Sealed method → cannot be overridden again in derived classes.

d)

Yes. A sealed class can be instantiated using new. It only prevents inheritance, not object creation.
 */

#endregion


using Assignment03oop;

Cinema cinema = new Cinema("Galaxy");

cinema.OpenCinema();

Ticket t1 = new StandardTicket("Inception", 120m, "A-5");
Ticket t2 = new VIPTicket("Avengers", 200m, true);
Ticket t3 = new IMAXTicket("Dune", 180m, false);

cinema.AddTicket(t1);
cinema.AddTicket(t2);
cinema.AddTicket(t3);

cinema.PrintAllTickets();

cinema.CloseCinema();
