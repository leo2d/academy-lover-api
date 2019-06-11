using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    class TokenMap : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.LoginDate)
                .HasColumnName("LoginDate");

            builder.Property(x => x.ExpirationDate)
                .HasColumnName("ExpirationDate");

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnName("UserId");


            builder.HasOne(x => x.User)
                .WithMany(y => y.Tokens)
                .HasForeignKey(x => x.UserId);

        }
    }

}
