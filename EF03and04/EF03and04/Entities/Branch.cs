namespace EF03and04.Entities;

public class Branch
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Code { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public int ManagerId { get; set; }
    public Manager Manager { get; set; }

    public List<Account> Accounts { get; set; } = new();
}