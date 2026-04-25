using EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF02.Configurations;

public class EventConfig : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(150);

        builder.HasOne(x => x.ParentEvent)
            .WithMany(x => x.Sessions)
            .HasForeignKey(x => x.ParentEventId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property<DateTime>("CreatedAt");
        builder.Property<DateTime>("UpdatedAt");
    }
}