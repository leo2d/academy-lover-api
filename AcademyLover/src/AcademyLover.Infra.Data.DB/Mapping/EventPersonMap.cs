using AcademyLover.Domain.AggregateModels.EventAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    public class EventPersonMap : IEntityTypeConfiguration<EventPerson>
    {
        public void Configure(EntityTypeBuilder<EventPerson> builder)
        {
            builder.ToTable("EventPerson");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.EventId)
                .IsRequired()
                .HasColumnName("EventId");

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnName("UserId");

            builder.Property(x => x.SubscribeDate)
                .IsRequired()
                .HasColumnName("SubscribeDate");

            builder.HasOne(x => x.Event)
                .WithMany(y => y.Subscribers)
                .HasForeignKey(x => x.EventId);

            builder.HasOne(x => x.Person)
                .WithMany(y => y.Events)
                .HasForeignKey(x => x.UserId);
        }

    }
}
