namespace BoletosBus.Api.Models.Usuario
{
    public class UsuarioGetModel : UsuarioBaseModel
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
    }
}
