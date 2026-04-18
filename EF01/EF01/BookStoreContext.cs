using Microsoft.EntityFrameworkCore;

namespace EF01;

public class BookStoreContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=ZEYAD\\SQLEXPRESS;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate=True");
    }
}