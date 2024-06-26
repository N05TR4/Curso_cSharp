﻿using BoletosBus.Domain.Core;


namespace BoletosBus.Domain.Entities
{
    public sealed class Reserva : BaseEntity
    {
        public int IdReserva { get; set; }
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public int AsientosReservados { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
