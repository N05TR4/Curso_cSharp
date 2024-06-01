﻿using BoletosBus.Domain.Core;
using BoletosBus.Domain.Interfaces;

namespace BoletosBus.Domain.Entities
{
    public sealed class Usuario : BasePerson
    {
        public int IdUsuario { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
    }
}
