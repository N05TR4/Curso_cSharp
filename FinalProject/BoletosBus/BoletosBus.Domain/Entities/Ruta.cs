using BoletosBus.Domain.Core;
using BoletosBus.Domain.Interfaces;

namespace BoletosBus.Domain.Entities
{
    public sealed class Ruta : BaseEntity
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
