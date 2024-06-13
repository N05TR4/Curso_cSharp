namespace BoletosBus.Api.Models.Usuario
{
    public class UsuarioSaveModel : UsuarioBaseModel
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
    }
}
