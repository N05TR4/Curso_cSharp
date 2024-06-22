using BoletosBus.WebApplication.Models;

namespace BoletosBus.WebApplication.Services
{
    public interface IUsuarioService : IBaseService<UsuarioModel>
    {
        Task<List<UsuarioModel>> GetAllUsuarioByTipoUsuario(string tipoUsuario);
    }
}
