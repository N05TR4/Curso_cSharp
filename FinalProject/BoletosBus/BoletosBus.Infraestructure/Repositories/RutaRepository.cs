
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Repositories
{
    public class RutaRepository : IRuta
    {
        private readonly BoletosBusDbContext _dbContext;

        public RutaRepository(DbContext dbContext) { }

        

        public Task<List<Ruta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Ruta> GetById(int idRuta)
        {
            throw new NotImplementedException();
        }

        public Task Save(Ruta ruta)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Ruta> rutas)
        {
            throw new NotImplementedException();
        }

        public Task Update(Ruta ruta)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Ruta> rutas)
        {
            throw new NotImplementedException();
        }

        public Task<Ruta> Delete(int idRuta)
        {
            throw new NotImplementedException();
        }
    }
}
