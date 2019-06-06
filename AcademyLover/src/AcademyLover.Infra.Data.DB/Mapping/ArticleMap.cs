using AcademyLover.Domain.AggregateModels.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Article");

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

            builder.Property(x => x.Authors)
                .IsRequired()
                .HasColumnName("Authors");

            builder.Property(x => x.EventId)
                .IsRequired()
                .HasColumnName("EventId");

            builder.Property(x => x.PersonId)
                .IsRequired()
                .HasColumnName("PersonId");

            builder.HasOne(x => x.Event)
                .WithMany(y => y.Articles)
                .HasForeignKey(x => x.EventId);

            builder.HasOne(x => x.Student)
                .WithMany(y => y.Articles)
                .HasForeignKey(x => x.PersonId);

        }
    }
}
