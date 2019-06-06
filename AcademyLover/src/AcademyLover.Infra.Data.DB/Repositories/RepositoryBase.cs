using AcademyLover.Domain.SharedKernel.Entities;
using AcademyLover.Domain.SharedKernel.Interfaces;
using AcademyLover.Infra.Data.DB.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AcademyLover.Infra.Data.DB.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity<T>
    {
        protected DataContext _dbCobtext { get; set; }

        public RepositoryBase(DataContext dataContext)
        {
            _dbCobtext = dataContext;
        }

        public IQueryable<T> FindAll()
        {
            return _dbCobtext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbCobtext.Set<T>()
                .Where(expression);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _dbCobtext.Set<T>()
                .FirstOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task Create(T entity)
        {
            try
            {
                _dbCobtext.Set<T>().Add(entity);

                _dbCobtext.SaveChanges();
                // await SaveAsync();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task Update(T entity)
        {
            _dbCobtext.Set<T>().Update(entity);
            await SaveAsync();
        }

        public async Task Delete(T entity)
        {
            _dbCobtext.Set<T>().Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _dbCobtext.SaveChangesAsync();
        }
    }
}
