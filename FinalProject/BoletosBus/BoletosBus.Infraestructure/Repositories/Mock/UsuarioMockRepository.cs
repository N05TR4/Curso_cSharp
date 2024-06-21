using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories.Mock
{
    public class UsuarioMockRepository : IUsuarioRepository
    {
        private List<Usuario> _usuarios;

        public UsuarioMockRepository()
        {
            this._usuarios = new List<Usuario>()
              {
                  new Usuario
                  {
                      IdUsuario = 1,
                      Nombres = "usuario 1",
                      Apellidos = "apellido 1",
                      Correo = "usuario1@example.com",
                      Clave = "clave1",
                      TipoUsuario = "Admin"
                  },

                  new Usuario
                  {
                        IdUsuario = 2,
                        Nombres = "usuario 2",
                        Apellidos = "apellido 2",
                        Correo = "usuario2@example.com",
                        Clave = "clave2",
                        TipoUsuario = "Pasajero"
                  }
              };
        }


        public Task<Usuario> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> Exist(Expression<Func<Usuario, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<UsuarioModel> GetAllUsuario()
        {
            return _usuarios.Select(u => new UsuarioModel
            {
               IdUsuario = u.IdUsuario,
                Nombres = u.Nombres,
                Apellidos = u.Apellidos,
                Correo = u.Correo,
                Clave = u.Clave,
                TipoUsuario = u.TipoUsuario 
            }).ToList();
        }

        public Task<List<UsuarioModel>> GetAllUsuarioByTipoUsuario(string tipoUsuario)
        {
            var usuario = _usuarios.Where(u => u.TipoUsuario == tipoUsuario)
                                    .Select(u => new UsuarioModel
                                    {
                                        IdUsuario = u.IdUsuario,
                                        Nombres = u.Nombres,
                                        Apellidos = u.Apellidos,
                                        Correo = u.Correo,
                                        Clave = u.Clave,
                                        TipoUsuario = u.TipoUsuario
                                    }).ToList();

            return Task.FromResult(usuario);
        }

        public Task<Usuario> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetUsuarioById(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.IdUsuario == id);
            if (usuario == null)
            {
                throw new KeyNotFoundException("Usuario no encontrado");
            }
            return new UsuarioModel
            {
                IdUsuario = usuario.IdUsuario,
                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Clave = usuario.Clave,
                TipoUsuario = usuario.TipoUsuario
            };
        }

        public Task Save(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Usuario> entities)
        {
            throw new NotImplementedException();
        }

        public Task Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Usuario> entities)
        {
            throw new NotImplementedException();
        }
    }
}
