using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Core;
using BoletosBus.Infraestructure.Extensions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public BusRepository(BoletosBusDbContext dbContext) : base(dbContext) {
        
            _dbContext = dbContext;
        }

        public BusModel GetBusByIdViaje(int IdViaje)
        {
            var busModel = this._dbContext.Bus.Find(IdViaje).ConvertBusEntityToBusModel();
            return busModel;
        }
    }
}
