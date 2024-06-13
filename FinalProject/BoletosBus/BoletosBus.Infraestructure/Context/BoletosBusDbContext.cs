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
            modelBuilder.Entity<Asiento>(entity =>
            {
                entity.HasKey(e => e.IdAsiento); // Definiendo la clave primaria
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasKey(e => e.IdBus);
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva);
            });

            modelBuilder.Entity<ReservaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdReservaDetalle);
            });

            modelBuilder.Entity<Ruta>(entity =>
            {
                entity.HasKey(e => e.IdRuta);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);
            });

            modelBuilder.Entity<Viaje>(entity =>
            {
                entity.HasKey(e => e.IdViaje);
            });
        }


    }
}
