using AcademyLover.Domain.AggregateModels.ArticleAgg;
using AcademyLover.Domain.AggregateModels.ArticleAgg.Interfaces.Repositories;
using AcademyLover.Infra.Data.DB.Context;

namespace AcademyLover.Infra.Data.DB.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
