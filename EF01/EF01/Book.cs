namespace EF01;

public class Book
{
    public int Id { get; set; }   // PK by convention

    public string Title { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
    public int Pages { get; set; }
    public int PublishYear { get; set; }
    public bool InStock { get; set; }

    public int AuthorId { get; set; }      // FK
    public Author Author { get; set; }

    public int CategoryId { get; set; }    // FK
    public Category Category { get; set; }
}