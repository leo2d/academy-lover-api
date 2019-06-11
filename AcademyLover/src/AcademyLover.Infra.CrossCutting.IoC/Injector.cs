using AcademyLover.Domain.AggregateModels.ArticleAgg.Interfaces.Repositories;
using AcademyLover.Domain.AggregateModels.EventAgg.Interfaces.Repositories;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces.Repositories;
using AcademyLover.Domain.AggregateModels.UserAgg.Services;
using AcademyLover.Infra.Data.DB.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AcademyLover.Infra.CrossCutting.IoC
{
    public static class Injector
    {
        public static void RegisterServices(IHostingEnvironment env, IServiceCollection services)
        {
            #region repositories
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            #endregion

            #region services
            services.AddScoped<IUserService, UserService>();

            #endregion
        }
    }
}
