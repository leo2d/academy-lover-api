using AcademyLover.Domain.SharedKernel.Entities;

namespace AcademyLover.Infra.Data.DB.Repositories
{
    public class RepositoryBase <T> where T : BaseEntity<T>
    {
    }
}
