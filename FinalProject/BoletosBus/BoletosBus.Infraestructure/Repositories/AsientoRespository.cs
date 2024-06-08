using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using BoletosBus.Infraestructure.Context;
using BoletosBus.Infraestructure.Core;
using BoletosBus.Infraestructure.Extensions;


namespace BoletosBus.Infraestructure.Repositories
{
    public class AsientoRespository : BaseRepository<Asiento>, IAsientoRepository
    {
        private readonly BoletosBusDbContext _dbContext;

        public AsientoRespository(BoletosBusDbContext Context) : base(Context)
        {
           this._dbContext = Context;
        }

        public AsientoModel GetAsiento(int idAsiento)
        {
            var asientoModel =this._dbContext.Asiento.Find(idAsiento)
                                            .ConvertAsientoEntityToAsientoModel();
            return asientoModel;
        }

        public List<AsientoReservaModel> GetAsientoReserva()
        {
            var asientos = (from a in this._dbContext.Asiento
                               join r in this._dbContext.Reserva on a.IdAsiento equals r.IdReserva
                               select new AsientoReservaModel() 
                               {

                               }
                            ).ToList();

            return asientos;
        }           
    }
}
