
using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletosBus.Infraestructure.Repositories
{
    public class RutaRepository : IRutaRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public RutaRepository(BoletosBusDbContext dbContext) 
        {
            _dbContext = dbContext;
        
        
        }


        
        
    }
}
