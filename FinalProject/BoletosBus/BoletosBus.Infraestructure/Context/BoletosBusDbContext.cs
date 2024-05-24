

using BoletosBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Context
{
    public class BoletosBusDbContext : DbContext
    {
        public BoletosBusDbContext(DbContextOptions<BoletosBusDbContext> dbContext) : base(dbContext)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asiento>().ToTable("", "");
            modelBuilder.Entity<Bus>().ToTable("", "");
            modelBuilder.Entity<Reserva>().ToTable("", "");
            modelBuilder.Entity<ReservaDetalle>().ToTable("", "");
            modelBuilder.Entity<Ruta>().ToTable("", "");
            modelBuilder.Entity<Viaje>().ToTable("", "");

            base.OnModelCreating(modelBuilder);
        }

        
    }
}
