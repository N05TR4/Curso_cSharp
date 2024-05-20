using BoletosBus.Domain.Core;




namespace BoletosBus.Domain.Entities
{
    public sealed class Asiento : BaseEntity
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
    }
}
