﻿

using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace BoletosBus.IOC.Dependence
{
    public static class AsientoDependecy
    {
        public static void AddAsientoDependency(this IServiceCollection services)
        {
            services.AddScoped<IAsientoRepository, AsientoRespository>();
        }
    }
}
