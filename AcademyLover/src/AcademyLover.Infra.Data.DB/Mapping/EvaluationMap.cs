using AcademyLover.Domain.AggregateModels.ArticleAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyLover.Infra.Data.DB.Mapping
{
    public class EvaluationMap : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.ToTable(" Evaluation");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("Id");

            builder.Property(x => x.ArticleId)
                .IsRequired()
                .HasColumnName("ArticleId");

            //builder.Property(x => x.EventId)
            //    .IsRequired()
            //    .HasColumnName("EventId");

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnName("UserId");

            builder.Property(x => x.Rate)
                .IsRequired()
                .HasColumnName("Rate");

            builder.Property(x => x.Comment)
                .IsRequired(false)
                .HasColumnName("Comment");

            builder.HasOne(x => x.Article)
                .WithMany(y => y.Evaluations)
                .HasForeignKey(x => x.ArticleId);

            builder.HasOne(x => x.Person)
                .WithMany(y => y.Evaluations)
                .HasForeignKey(x => x.UserId);

        }
    }
}
