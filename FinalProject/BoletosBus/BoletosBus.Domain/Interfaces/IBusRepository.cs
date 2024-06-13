using BoletosBus.Domain.Core;
using BoletosBus.Domain.Models;
using BoletosBus.Domain.Entities;


namespace BoletosBus.Domain.Interfaces
{
    public interface IBusRepository : IBaseRepository<Bus>
    {
        BusModel GetBusByIdViaje(int IdViaje);
        
    }
}
