using EF03and04.Entities;
using Microsoft.EntityFrameworkCore;

public class BankDbContext : DbContext
{
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<CustomerAccount> CustomerAccounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=.;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>()
            .HasOne(b => b.Manager)
            .WithOne(m => m.Branch)
            .HasForeignKey<Branch>(b => b.ManagerId);

        modelBuilder.Entity<Account>()
            .HasOne(a => a.Branch)
            .WithMany(b => b.Accounts)
            .HasForeignKey(a => a.BranchId);

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Account)
            .WithMany(a => a.Transactions)
            .HasForeignKey(t => t.AccountId);

        modelBuilder.Entity<CustomerAccount>()
            .HasKey(x => new { x.CustomerId, x.AccountId });

        modelBuilder.Entity<CustomerAccount>()
            .HasOne(x => x.Customer)
            .WithMany(c => c.CustomerAccounts)
            .HasForeignKey(x => x.CustomerId);

        modelBuilder.Entity<CustomerAccount>()
            .HasOne(x => x.Account)
            .WithMany(a => a.CustomerAccounts)
            .HasForeignKey(x => x.AccountId);
        
        
        modelBuilder.Entity<Manager>().HasData(
            new Manager
            {
                Id = 1,
                FullName = "Ahmed Ali",
                Email = "ahmed@test.com",
                PhoneNumber = "0100000000",
                HireDate = new DateTime(2020, 1, 1)
            }
        );

        modelBuilder.Entity<Branch>().HasData(
            new Branch
            {
                Id = 1,
                Name = "Main Branch",
                Code = "BR001",
                Address = "Cairo",
                PhoneNumber = "02222222",
                ManagerId = 1
            }
        );
    }

}