

using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IAsiento
    {


        //int IdAsiento { get; set; }
        //int IdBus { get; set; }
        //int NumeroPiso { get; set; }
        //int NumeroAsiento { get; set; }

        Task Save(Asiento asiento);

        Task Save(List<Asiento> asientos);

        Task Update(Asiento asiento);

        Task Update(List<Asiento> asientos);

        Task<Asiento> GetById(int idAsiento);

        Task<List<Asiento>> GetAll();

        Task<Asiento> Delete(int idAsiento);
    }
}
