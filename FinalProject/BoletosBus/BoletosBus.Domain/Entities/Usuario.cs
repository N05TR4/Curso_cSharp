using BoletosBus.Domain.Core;
using BoletosBus.Domain.Interfaces;

namespace BoletosBus.Domain.Entities
{
    public sealed class Usuario : BaseEntity
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
    }
}
