using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using AcademyLover.Domain.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcademyLover.Domain.AggregateModels.UserAgg.Interfaces.Repositories
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Task<Token> GetValidToken(string token);
        Task<Person> GetByLogin(string login, string password);
        Task DeleteToken(Token token);
    }
}
