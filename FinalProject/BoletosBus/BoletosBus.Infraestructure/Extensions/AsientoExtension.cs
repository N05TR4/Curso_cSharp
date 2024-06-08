
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Models;

namespace BoletosBus.Infraestructure.Extensions
{
    public static class AsientoExtension
    {
        public static AsientoModel ConvertAsientoEntityToAsientoModel(this Asiento asiento)
        {
            AsientoModel asientoModel = new AsientoModel()
            {
                IdAsiento = asiento.IdAsiento,
                IdBus = asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = asiento.NumeroAsiento

            };

            return asientoModel;
                
    
        }
    }
}
