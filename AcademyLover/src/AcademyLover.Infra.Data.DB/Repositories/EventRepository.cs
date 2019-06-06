using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.AggregateModels.EventAgg.Interfaces.Repositories;
using AcademyLover.Infra.Data.DB.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcademyLover.Infra.Data.DB.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await FindAll()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Event> GetEventWithDetailsAsync(int id)
        {
            var result = await _dbCobtext.Set<Event>()
                .Include(x => x.Articles)
                .Include(x => x.Subscribers)
                .FirstOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);

            return result;
        }
    }
}
