﻿using BoletosBus.Domain.Core;


namespace BoletosBus.Domain.Entities
{
    public sealed class ReservaDetalle : BaseEntity
    {
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }
    }
}
