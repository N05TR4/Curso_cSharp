

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public UsuarioRepository(DbContext dbContext) { }


        public Task<List<UsuarioModel>> GetAll(Expression<Func<UsuarioModel, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public Task<UsuarioModel> GetById(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task Save(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<UsuarioModel> usuarios)
        {
            throw new NotImplementedException();
        }

        public Task Update(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<UsuarioModel> usuarios)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Delete(int idUsuario)
        {
            throw new NotImplementedException();
        }

        
    }
}
