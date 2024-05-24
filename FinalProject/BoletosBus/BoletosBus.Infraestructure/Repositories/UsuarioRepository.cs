

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BoletosBus.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly BoletosBusDbContext _dbContext;

        public UsuarioRepository(DbContext dbContext) { }

        

        public Task<List<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetById(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task Save(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Usuario> usuarios)
        {
            throw new NotImplementedException();
        }

        public Task Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Usuario> usuarios)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Delete(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
