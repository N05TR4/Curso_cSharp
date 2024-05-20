using BoletosBus.Domain.Core;



namespace BoletosBus.Domain.Entities
{
    public sealed class Bus : BaseEntity
    {
        public int IdBus { get; set; }
        public string NumeroPlaca { get; set; }
        public string Nombre { get; set; }
        public int CapacidadPiso1 { get; set; }
        public int CapacidadPiso2 { get; set; }
        public int CapacidadTotal => CapacidadPiso1 + CapacidadPiso2;
        public bool Disponible { get; set; }
    }
}
