using AcademyLover.Domain.AggregateModels.ArticleAgg;
using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Infra.Data.DB.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AcademyLover.Infra.Data.DB.Context
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;
        public DataContext(IConfiguration configuration)
        {
            _connectionString = configuration
                .GetSection("ConnectionStrings:MysqlConnection")
                .Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(new EventMap().Configure);
            modelBuilder.Entity<Article>(new ArticleMap().Configure);

        }

    }

}
