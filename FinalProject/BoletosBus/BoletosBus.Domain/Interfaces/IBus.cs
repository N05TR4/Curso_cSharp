



using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IBus
    {
        //int IdBus { get; set; }
        //string NumeroPlaca { get; set; }
        //string Nombre { get; set; }
        //int CapacidadPiso1 { get; set; }
        //int CapacidadPiso2 { get; set; }
        //int CapacidadTotal { get; }
        //bool Disponible { get; set; }

        Task Save(Bus bus);

        Task Save(List<Bus> buses);

        Task Update(Bus bus);

        Task Update(List<Bus> buses);

        Task<Bus> GetById(int idBus);

        Task<List<Bus>> GetAll();

        Task<Bus> Delete(int idBus);
    }
}
