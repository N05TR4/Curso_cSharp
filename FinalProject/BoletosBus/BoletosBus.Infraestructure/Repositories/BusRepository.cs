using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;

using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Core;


namespace BoletosBus.Infraestructure.Repositories
{
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public BusRepository(BoletosBusDbContext dbContext) : base(dbContext) {
        
            _dbContext = dbContext;
        }


        
       
    }
}
