using BoletosBus.Api.Models.Bus;
using BoletosBus.Domain.Entities;

namespace BoletosBus.Api.Extension.BusExtension
{
    public static class BusExtension
    {
        public static BusModel ConvertBusEntityToBusModel(this Bus bus)
        {
            return new BusModel
            {
                IdBus = bus.IdBus,
                NumeroPlaca = bus.NumeroPlaca,
                Nombre = bus.Nombre,
                CapacidadPiso1 = bus.CapacidadPiso1,
                CapacidadPiso2 = bus.CapacidadPiso2,
                Disponible = bus.Disponible,
            };
        }

        public static Bus ToBus(this BusModel bus)
        {
            return new Bus {

                IdBus = bus.IdBus,
                NumeroPlaca = bus.NumeroPlaca,
                Nombre = bus.Nombre,
                CapacidadPiso1 = bus.CapacidadPiso1,
                CapacidadPiso2 = bus.CapacidadPiso2,
                Disponible = bus.Disponible,

            };
        }
    }
}
