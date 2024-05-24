

using BoletosBus.Domain.Entities;

namespace BoletosBus.Domain.Interfaces
{
    public interface IUsuario
    {
        Task Save(Usuario usuario);

        Task Save(List<Usuario> usuarios);

        Task Update(Usuario usuario);

        Task Update(List<Usuario> usuarios);

        Task<Usuario> GetById(int idUsuario);

        Task<List<Usuario>> GetAll();

        Task<Usuario> Delete(int idUsuario);
        //int IdUsuario { get; set; }
        //string Nombres { get; set; }
        //string Apellidos { get; set; }
        //string Correo { get; set; }
        //string Clave { get; set; }
        //string TipoUsuario { get; set; }
    }
}
