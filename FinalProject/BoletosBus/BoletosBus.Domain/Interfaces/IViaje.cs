

using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IViaje
    {
        Task Save(Viaje viaje);

        Task Save(List<Viaje> Viajes);

        Task Update(Viaje viaje);

        Task Update(List<Viaje> Viajes);

        Task<Viaje> GetById(int idViaje);

        Task<List<Viaje>> GetAll();

        Task<Viaje> Delete(int idViaje);
        //int IdViaje { get; set; }
        //int IdBus { get; set; }
        //int IdRuta { get; set; }
        //DateTime FechaSalida { get; set; }
        //TimeSpan HoraSalida { get; set; }
        //DateTime FechaLlegada { get; set; }
        //TimeSpan HoraLlegada { get; set; }
        //decimal Precio { get; set; }
        //int TotalAsientos { get; set; }
        //int AsientosReservados { get; set; }
        //int AsientoDisponibles { get; }
        //bool Completo { get; }
    }
}
