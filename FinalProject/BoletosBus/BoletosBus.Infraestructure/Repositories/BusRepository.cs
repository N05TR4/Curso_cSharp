using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;



namespace BoletosBus.Infraestructure.Repositories
{
    public class BusRepository : IBus
    {
        private readonly BoletosBusDbContext _dbContext;

        public BusRepository(DbContext dbContext) { }

       

        public Task<List<Bus>> GetAll()
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
