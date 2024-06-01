using BoletosBus.Domain.Core;


namespace BoletosBus.Domain.Entities
{
    public class Pasajero : BasePerson
    {
        public int IdPasajero { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
    }
}
