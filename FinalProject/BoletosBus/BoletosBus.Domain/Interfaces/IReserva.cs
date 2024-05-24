


using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IReserva
    {
        //public int IdReserva { get; set; }
        //public int IdViaje { get; set; }
        //public int IdPasajero { get; set; }
        //public int AsientosReservados { get; set; }
        //public decimal MontoTotal { get; set; }

        Task Save(Reserva reserva);

        Task Save(List<Reserva> reservas);

        Task Update(Reserva reserva);

        Task Update(List<Reserva> reservas);

        Task<Reserva> GetById(int idReserva);

        Task<List<Reserva>> GetAll();

        Task<Reserva> Delete(int idReserva);
    }
}
