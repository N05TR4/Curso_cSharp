

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class ReservaDetalleRepository : IReservaDetalleRepository
    {
        private readonly BoletosBusDbContext _dbContext;


        public ReservaDetalleRepository(DbContext dbContext) { }


        

        public Task<ReservaDetalle> GetById(int idReservaDetalle)
        {
            throw new NotImplementedException();
        }

        public Task Save(ReservaDetalle reservaDetalle)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<ReservaDetalle> reservasDetalle)
        {
            throw new NotImplementedException();
        }

        public Task Update(ReservaDetalle reservaDetalle)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<ReservaDetalle> reservasDetalle)
        {
            throw new NotImplementedException();
        }

        public Task<ReservaDetalle> Delete(int idReservaDetalle)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReservaDetalle>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<ReservaDetalle>> Exist(Expression<Func<ReservaDetalle, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
