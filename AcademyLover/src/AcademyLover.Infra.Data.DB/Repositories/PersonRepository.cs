using AcademyLover.Domain.AggregateModels.UserAgg;
using AcademyLover.Domain.AggregateModels.UserAgg.Entities;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces.Repositories;
using AcademyLover.Infra.Data.DB.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace AcademyLover.Infra.Data.DB.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<Token> GetValidToken(string token)
        {
            var result = await _dbCobtext.Set<Token>()
                  .FirstOrDefaultAsync(x => x.Value.Trim().Equals(token) &&
                                          x.ExpirationDate >= DateTime.Now);


            return result;
        }

        public async Task<Person> GetByLogin(string login, string password)
        {
            var user = await _dbCobtext.Set<Person>()
                .Include(x=> x.Tokens)
                .FirstOrDefaultAsync(x => x.Login.ToLower().Equals(login.Trim().ToLower())
                &&  x.Password.Equals(password));

            return user;
        }

        public async Task DeleteToken(Token token)
        {
             _dbCobtext.Set<Token>()
                .Remove(token);

            await SaveAsync();
        }
    }
}
