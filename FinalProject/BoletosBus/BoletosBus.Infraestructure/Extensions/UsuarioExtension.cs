

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Models;

namespace BoletosBus.Infraestructure.Extensions
{
    public static class UsuarioExtension
    {
        public static UsuarioModel ConvertUsuarioEntityToUsuarioModel(this Usuario usuario) 
        {
            UsuarioModel usuarioModel = new UsuarioModel()
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Clave = usuario.Clave,
                TipoUsuario = usuario.TipoUsuario


            };

            return usuarioModel;
        }

    }
}
