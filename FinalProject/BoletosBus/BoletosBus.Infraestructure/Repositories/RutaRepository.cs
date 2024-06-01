
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class RutaRepository : IRuta
    {
        private readonly BoletosBusDbContext _dbContext;

        public RutaRepository(DbContext dbContext) { }


        public Task<List<RutaModel>> GetAll(Expression<Func<RutaModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<RutaModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RutaModel> GetById(int idRuta)
        {
            throw new NotImplementedException();
        }

        public Task Save(RutaModel ruta)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<RutaModel> rutas)
        {
            throw new NotImplementedException();
        }

        public Task Update(RutaModel ruta)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<RutaModel> rutas)
        {
            throw new NotImplementedException();
        }

        public Task<RutaModel> Delete(int idRuta)
        {
            throw new NotImplementedException();
        }

        
    }
}
