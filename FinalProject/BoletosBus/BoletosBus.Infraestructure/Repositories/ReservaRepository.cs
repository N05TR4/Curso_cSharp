



using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public ReservaRepository(DbContext dbContext) { }



        public Task<List<Reserva>> GetAll(Expression<Func<Reserva, bool>> filter)
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
