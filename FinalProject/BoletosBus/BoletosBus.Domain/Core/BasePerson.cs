

namespace BoletosBus.Domain.Core
{
    public abstract class BasePerson : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }

    }
}
