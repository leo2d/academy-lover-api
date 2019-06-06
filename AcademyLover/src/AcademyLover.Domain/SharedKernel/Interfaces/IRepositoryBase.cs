using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AcademyLover.Domain.SharedKernel.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> FindByIdAsync(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveAsync();
    }
}
