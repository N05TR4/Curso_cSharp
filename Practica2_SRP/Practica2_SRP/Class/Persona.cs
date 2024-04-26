using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_SRP.Class
{
    public class Persona
    {
        public string nombre { get; set;  }
        public int edad {get; set; }
        public string direccion {get; set; }
        public string correoElectronico {get; set; }

        public Persona(string _nombre, int _edad, string _direccion, string _correo) 
        { 
            nombre = _nombre;
            edad = _edad;
            direccion = _direccion;
            correoElectronico = _correo;

        }

    }
}
