
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BoletosBus.IOC.Dependencies
{
    public static class UsuarioDependency
    {
        public static void AddUsuarioDependecy(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        }

    }
}
