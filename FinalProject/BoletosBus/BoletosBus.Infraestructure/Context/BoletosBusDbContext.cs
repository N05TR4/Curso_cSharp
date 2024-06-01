

using BoletosBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Context
{
    public class BoletosBusDbContext : DbContext
    {
        public BoletosBusDbContext(DbContextOptions<BoletosBusDbContext> dbContext) : base(dbContext)
        {
            
        }

        DbSet<Asiento> Asiento { get; set; }
        DbSet<Bus> Bus { get; set; }
        DbSet<Reserva> Reserva { get; set; }
        DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        DbSet<Ruta> Ruta { get; set; }
        DbSet<Usuario> Usuario { get; set; }
        DbSet<Viaje> Viaje { get; set; }


    }
}
