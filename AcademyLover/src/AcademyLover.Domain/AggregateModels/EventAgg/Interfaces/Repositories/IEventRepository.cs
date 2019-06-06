using AcademyLover.Domain.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcademyLover.Domain.AggregateModels.EventAgg.Interfaces.Repositories
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventWithDetailsAsync(int id);

    }
}
