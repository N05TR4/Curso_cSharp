



using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class PasajeroRepository : IPasajero
    {

        private readonly BoletosBusDbContext _dbContext;

        public PasajeroRepository(DbContext dbContext) { }



        public Task<Pasajero> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pasajero>> Exist(Expression<Func<Pasajero, bool>> filter)
        {
            throw new NotImplementedException();
        }

       

        public Task<List<Pasajero>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pasajero> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Save(Pasajero entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Pasajero> entities)
        {
            throw new NotImplementedException();
        }

        public Task Update(Pasajero entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Pasajero> entities)
        {
            throw new NotImplementedException();
        }
    }
}
