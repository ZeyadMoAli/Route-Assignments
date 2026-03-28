namespace Assignment06oop;

public partial class Cinema
{
    private Ticket[] tickets = new Ticket[20];

    public void AddTicket(Ticket t)
    {
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                break;
            }
        }
    }

    public Ticket[] GetTickets()
    {
        return tickets;
    }
}