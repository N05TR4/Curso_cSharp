

namespace BoletosBus.Domain.Core
{
    public abstract class BasePerson : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }

    }
}
