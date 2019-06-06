using AcademyLover.Domain.AggregateModels.EventAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    public class CancellationMap : IEntityTypeConfiguration<Cancellation>
    {
        public void Configure(EntityTypeBuilder<Cancellation> builder)
        {
            builder.ToTable("Cancellation");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.EventId)
                .IsRequired()
                .HasColumnName("EventId");

            builder.Property(x => x.CancellationDate)
                .IsRequired()
                .HasColumnName("CancellationDate");

            builder.Property(x => x.Reason)
                .IsRequired()
                .HasColumnName("Reason");

            builder.HasOne(x => x.Event)
                .WithOne(x => x.Cancellation)
                .HasForeignKey<Cancellation>(x => x.EventId);
        }
    }
}
