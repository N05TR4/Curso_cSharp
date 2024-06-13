namespace BoletosBus.Api.Models.Usuario
{
    public class UsuarioUpdateModel : UsuarioBaseModel
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }

    }
}
