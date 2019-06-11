using AcademyLover.Infra.Data.DB.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AcademyLover.Api.Configuration
{
    public static class InitializeDB
    {
        public static void InitializeDb(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
