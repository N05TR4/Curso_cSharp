

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Repositories
{
    public class Viajerepository : IViaje
    {
        private readonly BoletosBusDbContext _dbContext;

        public Viajerepository(DbContext dbContext)
        {
            
        }

        
        public Task<List<Viaje>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> GetById(int idViaje)
        {
            throw new NotImplementedException();
        }

        public Task Save(Viaje viaje)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Viaje> Viajes)
        {
            throw new NotImplementedException();
        }

        public Task Update(Viaje viaje)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Viaje> Viajes)
        {
            throw new NotImplementedException();
        }

        public Task<Viaje> Delete(int idViaje)
        {
            throw new NotImplementedException();
        }

    }
}
