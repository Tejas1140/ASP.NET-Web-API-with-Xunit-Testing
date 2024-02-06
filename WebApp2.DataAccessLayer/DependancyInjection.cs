using Microsoft.Extensions.DependencyInjection;
using WebApp2.DataAccessLayer.Implementation;
using WebApp2.DataAccessLayer.Interface;

namespace WebApp2.DataAccessLayer
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddDbContext<NpgSqlDBContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
