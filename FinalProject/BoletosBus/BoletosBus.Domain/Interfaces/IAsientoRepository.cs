

using BoletosBus.Domain.Core;
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Models;

namespace BoletosBus.Domain.Interfaces
{
    public interface IAsientoRepository : IBaseRepository<Asiento>
    {
        List<AsientoReservaModel> GetAsientoReserva();
        AsientoModel GetAsiento(int idAsiento);
        

    }
}
