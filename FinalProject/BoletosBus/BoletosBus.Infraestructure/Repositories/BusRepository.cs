using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class BusRepository : IBus
    {
        private readonly BoletosBusDbContext _dbContext;

        public BusRepository(BoletosBusDbContext dbContext) {
        
            _dbContext = dbContext;
        }


        public Task<List<Bus>> GetAll(Expression<Func<Bus, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public Task<Bus> GetById(int idBus)
        {
            throw new NotImplementedException();
        }

        public Task Save(Bus bus)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Bus> buses)
        {
            throw new NotImplementedException();
        }

        public Task Update(Bus bus)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Bus> buses)
        {
            throw new NotImplementedException();
        }

        public Task<Bus> Delete(int idBus)
        {
            throw new NotImplementedException();
        }

       
    }
}
