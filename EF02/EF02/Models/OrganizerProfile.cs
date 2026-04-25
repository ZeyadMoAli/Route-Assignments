using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF02.Models;

public class OrganizerProfile
{
    [Key, ForeignKey("Organizer")]
    public int OrganizerId { get; set; }

    public string Bio { get; set; }

    public string Website { get; set; }

    public string LogoUrl { get; set; }

    public Organizer Organizer { get; set; }
}