

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public ViajeRepository(BoletosBusDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        public Task<List<ViajeModel>> GetAll(Expression<Func<ViajeModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<ViajeModel> GetById(int idViaje)
        {
            throw new NotImplementedException();
        }

        public Task Save(ViajeModel viaje)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<ViajeModel> Viajes)
        {
            throw new NotImplementedException();
        }

        public Task Update(ViajeModel viaje)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<ViajeModel> Viajes)
        {
            throw new NotImplementedException();
        }

        public Task<ViajeModel> Delete(int idViaje)
        {
            throw new NotImplementedException();
        }

       
    }
}
