using BoletosBus.Domain.Core;
using BoletosBus.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosBus.Domain.Entities
{
    public sealed class ReservaDetalle : BaseEntity
    {
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }
    }
}
