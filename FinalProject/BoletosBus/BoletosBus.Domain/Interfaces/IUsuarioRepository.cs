

using BoletosBus.Domain.Core;
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Models;

namespace BoletosBus.Domain.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        List<UsuarioModel> GetAllUsuario();
        UsuarioModel  GetUsuarioById(int id);
    }
}
