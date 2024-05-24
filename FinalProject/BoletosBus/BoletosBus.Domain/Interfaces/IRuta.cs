

using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IRuta
    {
        Task Save(Ruta ruta);

        Task Save(List<Ruta> rutas);

        Task Update(Ruta ruta);

        Task Update(List<Ruta> rutas);

        Task<Ruta> GetById(int idRuta);

        Task<List<Ruta>> GetAll();

        Task<Ruta> Delete(int idRuta);
    }
}
