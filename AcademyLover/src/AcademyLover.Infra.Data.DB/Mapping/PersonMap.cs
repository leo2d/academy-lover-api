using AcademyLover.Domain.AggregateModels.UserAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.Login)
                .IsRequired()
                .HasColumnName("Login");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnName("Password");

            builder.Property(x => x.Name)
                .HasColumnName("Name");

            builder.Property(x => x.Nationality)
                .HasColumnName("Nationality");

            builder.Property(x => x.Profile)
                .HasColumnName("Profile");

            builder.Property(x => x.School)
                .HasColumnName("School");

            builder.Property(x => x.BirthDate)
                .HasColumnName("BirthDate");

            builder.Property(x => x.Adress)
                .HasColumnName("Adress");


        }
    }
}
