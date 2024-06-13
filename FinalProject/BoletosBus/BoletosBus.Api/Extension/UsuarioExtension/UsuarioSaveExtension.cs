using BoletosBus.Api.Models.Usuario;
using BoletosBus.Domain.Entities;


namespace BoletosBus.Api.Extension.UsuarioExtension
{
    public static class UsuarioSaveExtension
    {
        public static UsuarioSaveModel ConvertUsuarioEntityToUsuarioSaveModel(this Usuario usuario)
        {
            return new UsuarioSaveModel
            {

                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Clave = usuario.Clave,
                TipoUsuario = usuario.TipoUsuario,

            };

        }

        public static Usuario ToUsuario(this UsuarioSaveModel saveModel)
        {
            return new Usuario
            {
                Nombres = saveModel.Nombres,
                Apellidos = saveModel.Apellidos,
                Correo = saveModel.Correo,
                Clave = saveModel.Clave,
                TipoUsuario = saveModel.TipoUsuario,

            };
        }
    }
}
