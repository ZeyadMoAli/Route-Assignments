using System.ComponentModel.DataAnnotations;

namespace EF02.Models;

public class Organizer
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public string CompanyName { get; set; }

    public bool IsVerified { get; set; }

    public OrganizerProfile Profile { get; set; }

    public List<Event> Events { get; set; } = new();
}