using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Models;

namespace BoletosBus.Infraestructure.Extensions
{
    public static class BusExtension
    {
        public static BusModel ConvertBusEntityToBusModel(this Bus bus)
        {
            BusModel busModel = new BusModel()
            {
                IdBus = bus.IdBus,
                NumeroPlaca = bus.NumeroPlaca,
                Nombre = bus.Nombre,
                CapacidadPiso1 = bus.CapacidadPiso1,
                CapacidadPiso2 = bus.CapacidadPiso2,
                Disponible = bus.Disponible,

            };

            return busModel;

        }
    }
}
