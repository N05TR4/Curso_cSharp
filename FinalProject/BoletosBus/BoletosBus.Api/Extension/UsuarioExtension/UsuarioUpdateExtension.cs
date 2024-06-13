using BoletosBus.Api.Models.Usuario;
using BoletosBus.Domain.Entities;

namespace BoletosBus.Api.Extension.UsuarioExtension
{
    public static class UsuarioUpdateExtension
    {
        public static UsuarioUpdateModel ConvertUsuarioEntityToUsuarioUpdateModel(this Usuario usuario)
        {
            return new UsuarioUpdateModel
            {
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Clave = usuario.Clave,
                TipoUsuario = usuario.TipoUsuario,
            };
        }

        public static Usuario ToUsuario(this UsuarioUpdateModel usuario)
        {
            return new Usuario
            {
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Clave = usuario.Clave,
                TipoUsuario = usuario.TipoUsuario,
            };

        }
    }
}
