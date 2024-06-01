using BoletosBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Context
{
    public partial class BoletosBusDbContext : DbContext
    {
        public BoletosBusDbContext(DbContextOptions<BoletosBusDbContext> dbContext) : base(dbContext)
        {
            
        }

        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Viaje> Viaje { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
