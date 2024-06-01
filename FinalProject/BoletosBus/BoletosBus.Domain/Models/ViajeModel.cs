

namespace BoletosBus.Domain.Models
{
    public sealed class ViajeModel 
    {
        public int IdViaje { get; set; }
        public int IdBus { get; set; }
        public int IdRuta { get; set; }
        public DateTime FechaSalida { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public TimeSpan HoraLlegada { get; set; }
        public decimal Precio { get; set; }
        public int TotalAsientos { get; set; }
        public int AsientosReservados { get; set; }
        public int AsientoDisponibles => TotalAsientos - AsientosReservados;
        public bool Completo => AsientoDisponibles < 1;
        public string? Bus {  get; set; }
        public string? Ruta { get; set;}
    }
}
