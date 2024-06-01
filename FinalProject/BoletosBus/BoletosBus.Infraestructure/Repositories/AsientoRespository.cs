using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class AsientoRespository : IAsiento
    {
        private readonly BoletosBusDbContext _dbContext;

        public AsientoRespository(BoletosBusDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public Task<List<Asiento>> GetAll(Expression<Func<Asiento, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Asiento> GetById(int idAsiento)
        {
            throw new NotImplementedException();
        }

        public Task Save(Asiento asiento)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Asiento> asientos)
        {
            throw new NotImplementedException();
        }

        public Task Update(Asiento asiento)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Asiento> asientos)
        {
            throw new NotImplementedException();

        }

        public Task<Asiento> Delete(int idAsiento)
        {
            throw new NotImplementedException();
        }

        public Task<Asiento> GetAllAsientoByBus(Bus IdBus)
        {
            throw new NotImplementedException();
        }
    }
}
