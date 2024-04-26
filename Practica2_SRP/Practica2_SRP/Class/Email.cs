using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica2_SRP.Interfaces;

namespace Practica2_SRP.Class
{
    public class Email : ICorreoElectronico
    {
        private Persona _persona;

        public Email(Persona persona) 
        { 
            _persona = persona;
        }

        public void EnviarCorreoElectronico(string mensaje)
        {
           

            Console.WriteLine($"Enviando correo electrónico a {_persona.correoElectronico}: {mensaje}");
            Console.WriteLine("Cooreo enviado");
        }
    }
    
}
