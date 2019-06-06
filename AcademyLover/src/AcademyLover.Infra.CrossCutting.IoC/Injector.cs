using AcademyLover.Domain.AggregateModels.EventAgg.Interfaces.Repositories;
using AcademyLover.Infra.Data.DB.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AcademyLover.Infra.CrossCutting.IoC
{
    public static class Injector
    {
        public static void RegisterServices(IHostingEnvironment env, IServiceCollection services)
        {
            services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}
