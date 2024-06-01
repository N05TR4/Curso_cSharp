

namespace BoletosBus.Domain.Models
{
    public class AsientoModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public string? NombreBus { get; set; }
    }
}
