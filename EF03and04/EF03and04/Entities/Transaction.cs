namespace EF03and04.Entities;

public class Transaction
{
    public int Id { get; set; }

    public string TransactionNumber { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public string TransactionType { get; set; }
    public string Note { get; set; }

    public int AccountId { get; set; }
    public Account Account { get; set; }
}