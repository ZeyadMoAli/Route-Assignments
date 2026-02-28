namespace Assignment02oop;

public class Cinema
{
    private Ticket[] tickets = new Ticket[20];

    public Ticket this[int index]
    {
        get
        {
            if (index < 0 || index >= tickets.Length)
                return null;
            return tickets[index];
        }
        set
        {
            if (index >= 0 && index < tickets.Length)
                tickets[index] = value;
        }
    }

    public Ticket GetMovie(string movieName)
    {
        foreach (var t in tickets)
        {
            if (t != null && t.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                return t;
        }
        return null;
    }

    public bool AddTicket(Ticket t)
    {
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return true;
            }
        }
        return false;
    }
}