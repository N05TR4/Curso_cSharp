

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Core;
using BoletosBus.Infraestructure.Extensions;


namespace BoletosBus.Infraestructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public UsuarioRepository(BoletosBusDbContext dbContext) : base(dbContext) 
        {
            this._dbContext = dbContext;
        }

        public List<UsuarioModel> GetAllUsuario()
        {
            var listusuarioModel = this._dbContext.Usuario
                                                  .Select(usuario => new UsuarioModel
                                                  {
                                                      IdUsuario = usuario.IdUsuario,
                                                      Nombres = usuario.Nombres, 
                                                      Apellidos = usuario.Apellidos,
                                                      Correo = usuario.Correo,
                                                      Clave = usuario.Clave,
                                                      TipoUsuario = usuario.TipoUsuario

                                                  }).ToList();
            return listusuarioModel;
        }

        public UsuarioModel GetUsuarioById(int id)
        {
            var usuarioModel = this._dbContext.Usuario.Find(id)
                                                      .ConvertUsuarioEntityToUsuarioModel();

            return usuarioModel;
        }
    }
}
