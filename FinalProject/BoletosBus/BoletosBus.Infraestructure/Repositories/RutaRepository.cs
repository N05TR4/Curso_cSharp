
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class RutaRepository : IRutaRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public RutaRepository(BoletosBusDbContext dbContext) 
        {
            _dbContext = dbContext;
        
        
        }

        public Task<Ruta> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ruta>> Exist(Expression<Func<Ruta, bool>> filter)
        {
            throw new NotImplementedException();
        }

        

        public Task<List<Ruta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Ruta> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Save(Ruta entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Ruta> entities)
        {
            throw new NotImplementedException();
        }

        public Task Update(Ruta entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Ruta> entities)
        {
            throw new NotImplementedException();
        }
    }
}
