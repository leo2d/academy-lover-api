using AcademyLover.Infra.CrossCutting.IoC;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AcademyLover.Api.Configuration
{
    public static class DIConfiguration
    {
        public static void AddDIConfiguration (this IServiceCollection services, IHostingEnvironment env) 
        {
            Injector.RegisterServices(env, services:services);
        }
    }
}

