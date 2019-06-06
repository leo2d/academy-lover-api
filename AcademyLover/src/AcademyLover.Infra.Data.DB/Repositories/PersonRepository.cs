using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces.Repositories;
using AcademyLover.Infra.Data.DB.Context;

namespace AcademyLover.Infra.Data.DB.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
