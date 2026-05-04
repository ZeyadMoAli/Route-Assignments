namespace EF03and04.Entities;

public class Account
{
    public int Id { get; set; }

    public string AccountNumber { get; set; }
    public string AccountType { get; set; }
    public DateTime OpeningDate { get; set; }
    public decimal CurrentBalance { get; set; }

    public int BranchId { get; set; }
    public Branch Branch { get; set; }

    public List<CustomerAccount> CustomerAccounts { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();
}