using AcademyLover.Domain.AggregateModels.ArticleAgg;
using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Infra.Data.DB.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AcademyLover.Infra.Data.DB.Context
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;
        public DataContext(IConfiguration configuration, DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>(new EventMap().Configure);
            modelBuilder.Entity<Article>(new ArticleMap().Configure);
            modelBuilder.Entity<Person>(new PersonMap().Configure);

        }

    }

}
