using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;



namespace BoletosBus.Infraestructure.Repositories
{
    public class AsientoRespository : IAsiento
    {
        private readonly BoletosBusDbContext _dbContext;

        public AsientoRespository(DbContext dbContext){}


        public Task<List<Asiento>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Asiento> GetById(int idAsiento)
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
    }
}
