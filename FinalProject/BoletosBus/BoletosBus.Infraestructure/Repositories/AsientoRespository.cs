using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class AsientoRespository : BaseRepository<Asiento>, IAsientoRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public AsientoRespository(BoletosBusDbContext Context) : base(Context)
        {
            _dbContext = Context;
        }

        

        List<AsientoModel> IAsientoRepository.GetAllAsientoByBus(Bus IdBus)
        {
            throw new NotImplementedException();
        }
    }
}
