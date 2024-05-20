

namespace BoletosBus.Domain.Core
{
    public abstract class BaseEntity
    {
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
