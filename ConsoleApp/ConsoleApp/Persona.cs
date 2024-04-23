using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Persona
    {

        //Atributos
        public string? Nombre { get; set; }

        public int Edad { get; set; }

        public string? Ciudad { get; set; }


        //Constructor clase persona
        public Persona( string _nombre, int _edad, string _ciudad) 
        {
            Nombre = _nombre;
            Edad = _edad;
            Ciudad = _ciudad;
        }


        // Método para mostrar la información de la persona
        public abstract void MostrarInformacion();
        
        

        // Metodo para calcular la edad en años
        public abstract int CalcularEdad(DateTime FechaNacimiento);
        
        

    }
}
