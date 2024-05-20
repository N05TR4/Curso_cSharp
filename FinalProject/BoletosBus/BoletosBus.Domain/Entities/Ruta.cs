using BoletosBus.Domain.Core;





namespace BoletosBus.Domain.Entities
{
    public sealed class Ruta : BaseEntity
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
