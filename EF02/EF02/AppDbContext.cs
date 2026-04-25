using EF02.Configurations;
using EF02.Models;
using Microsoft.EntityFrameworkCore;

namespace EF02;

public class AppDbContext : DbContext
{
    public DbSet<Organizer> Organizers { get; set; }
    public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Attendee> Attendees { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<Registration> Registrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EventConfig());
        modelBuilder.ApplyConfiguration(new RegistrationConfig());

        modelBuilder.Entity<Attendee>(entity =>
        {
            entity.Property(x => x.FullName).IsRequired().HasMaxLength(100);

            entity.OwnsOne(x => x.Address);

            entity.HasOne(x => x.Badge)
                .WithOne(x => x.Attendee)
                .HasForeignKey<Badge>(x => x.AttendeeId);
        });
    }
}
