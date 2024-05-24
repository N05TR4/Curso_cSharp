



using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Repositories
{
    public class ReservaRepository : IReserva
    {
        private readonly BoletosBusDbContext _dbContext;

        public ReservaRepository(DbContext dbContext) { }

        

        public Task<List<Reserva>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Reserva> GetById(int idReserva)
        {
            throw new NotImplementedException();
        }

        public Task Save(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Reserva> reservas)
        {
            throw new NotImplementedException();
        }

        public Task Update(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Reserva> reservas)
        {
            throw new NotImplementedException();
        }

        public Task<Reserva> Delete(int idReserva)
        {
            throw new NotImplementedException();
        }
    }
}
