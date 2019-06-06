using AcademyLover.Domain.AggregateModels.EventAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnName("Title");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnName("Description");

            builder.Property(x => x.Responsible)
                .IsRequired()
                .HasColumnName("Responsible");

            builder.Property(x => x.State)
                .IsRequired()
                .HasColumnName("State");

            builder.Property(x => x.Local)
                .IsRequired()
                .HasColumnName("Local");

            builder.Property(x => x.Situation)
                .IsRequired()
                .HasColumnName("Situation");

            builder.Property(x => x.Date)
                .IsRequired()
                .HasColumnName("Date");

            builder.Ignore(x => x.Subscribers);
                
        }
    }
}
