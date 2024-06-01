

using BoletosBus.Domain.Core;
using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IAsiento : IBaseRepository<Asiento>
    {
        Task<Asiento> GetAllAsientoByBus(Bus IdBus);

    }
}
