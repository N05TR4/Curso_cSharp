using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica2_SRP.Interfaces;



namespace Practica2_SRP.Class
{
    public class Imprimir : IPrinterData
    {
        private Persona _persona;

        
        public Imprimir(Persona persona)
        {
            _persona = persona;
        }


        public void ImprimiData()
        {
            Console.WriteLine($"Nombre: {_persona.nombre}");
            Console.WriteLine($"Edad: {_persona.edad}");
            Console.WriteLine($"Dirección: {_persona.direccion}");
            Console.WriteLine($"Correo Electrónico: {_persona.correoElectronico}");
        }

    }
    
}
