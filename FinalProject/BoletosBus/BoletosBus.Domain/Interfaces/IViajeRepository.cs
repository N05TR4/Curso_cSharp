

using BoletosBus.Domain.Core;
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Models;

namespace BoletosBus.Domain.Interfaces
{
    public interface IViajeRepository : IBaseRepository<Viaje>
    {
        List<ViajeUsuarioModel> GetAllViajeUsuario();
    }
}
