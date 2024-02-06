using Microsoft.Extensions.DependencyInjection;
using WebApp2.BusinessLayer.Services.Implementation;
using WebApp2.BusinessLayer.Services.Interface;
using WebApp2.DataAccessLayer;

namespace WebApp2.BusinessLayer;

public static class DependancyInjection
{
    public static IServiceCollection AddBussinessLayer(this IServiceCollection services)
    {
        services.AddDataAccessLayer();
        services.AddScoped<IMemberService, MemberService>();
        return services;
    }
}
