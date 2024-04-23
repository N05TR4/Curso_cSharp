using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace ConsoleApp
{
    public class Estudiante : Persona
    {

        //Atributos
        public string Carrera { get; set; }

        public string Matricula { get; set; }


        // Contructor de la clase
        public Estudiante(string _nombre, int _edad, string _ciudad, string _carrera, string _matricula) : base(_nombre, _edad, _ciudad)
        {

            Carrera = _carrera;
            Matricula = _matricula;

        }


        //Metodo para mostrar la información del estudiante
    
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}, Carrera: {Carrera}, Matrícula: {Matricula}");
        }


        // Metodo para calcular la Edad de un estudiante
        public override int CalcularEdad(DateTime FechaNacimiento)
        {
            var year = DateTime.Now.Year;
            var edad = year - FechaNacimiento.Year;

            return edad;
        }
    }
}
