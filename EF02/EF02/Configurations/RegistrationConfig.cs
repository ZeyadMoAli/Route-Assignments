using EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF02.Configurations;
public class RegistrationConfig : IEntityTypeConfiguration<Registration>
{
    public void Configure(EntityTypeBuilder<Registration> builder)
    {
        builder.HasKey(x => new { x.AttendeeId, x.EventId });

        builder.Property(x => x.RegisteredAt)
            .HasDefaultValueSql("GETDATE()");
    }
}