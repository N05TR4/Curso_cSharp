
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BoletosBus.IOC.Dependencie
{
    public static class UsuarioDependency
    {
        public static void addUsuarioDependecy(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        }

    }
}
