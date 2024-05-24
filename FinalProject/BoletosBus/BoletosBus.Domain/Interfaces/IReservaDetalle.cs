


using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IReservaDetalle
    {
        //int IdReservaDetalle { get; set; }
        //int IdReserva { get; set; }
        //int IdAsiento { get; set; }


        Task Save(ReservaDetalle reservaDetalle);

        Task Save(List<ReservaDetalle> reservasDetalle);

        Task Update(ReservaDetalle reservaDetalle);

        Task Update(List<ReservaDetalle> reservasDetalle);

        Task<ReservaDetalle> GetById(int idReservaDetalle);

        Task<List<ReservaDetalle>> GetAll();

        Task<ReservaDetalle> Delete(int idReservaDetalle);
    }
}
