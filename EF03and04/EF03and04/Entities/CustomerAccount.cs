namespace EF03and04.Entities;

public class CustomerAccount
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public int AccountId { get; set; }
    public Account Account { get; set; }

    public DateTime OwnershipStartDate { get; set; }
    public string OwnershipType { get; set; }   // Primary / CoHolder
    public string AccountStatus { get; set; }   // Active / Closed
}