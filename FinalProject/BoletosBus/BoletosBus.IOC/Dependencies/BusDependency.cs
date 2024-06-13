using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace BoletosBus.IOC.Dependencies
{
    public static class BusDependency
    {
        public static void AddBusDependency(this IServiceCollection services)
        {
            services.AddScoped<IBusRepository, BusRepository>();
        }
    }
}
