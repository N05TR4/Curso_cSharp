

using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class ViajeRepository : BaseRepository<Viaje>, IViajeRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public ViajeRepository(BoletosBusDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            
        }

        public List<ViajeUsuarioModel> GetAllViajeUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
