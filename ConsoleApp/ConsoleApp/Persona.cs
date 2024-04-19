using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Persona
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
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
        }

        // Metodo para calcular la edad en años
        public int CalcularEdadEnAnnos()
        {
            var year = DateTime.Now.Year;
            var result = year - Edad;

            return result;
        }

    }
}
