using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    //Clase abstracta figura
    public abstract class Figura
    {
        // Metodo abstracto para calcular el area de las figuras
        public abstract double CalcularArea();
    }


    // Clase Rectangulo que hereda de la clase abstracta Figura
    public class Rectangulo : Figura
    {
        public double Base {  get; set; }
        public double Altura { get; set; }


        // Metodo para calcular el area de un Rectangulo
        public override double CalcularArea()
        {
            var result = Base * Altura;
            
            return result;
        }

    }


    //Clase Circulo que hereda de la clase abstracta Figura
    public class Circulo : Figura
    {
        //Atributos
        public double Radio { get; set; }

        // Metodo para calcular el area de un Circulo
        public override double CalcularArea()
        {
            var result = Math.PI * Math.Pow(Radio, 2);

            return result;
        }
    }



    //Clase Triangulo que hereda de la clase abstracta Figura
    public class Triangulo : Figura
    {
        //Atributos
        public double Base { get; set; }
        public double Altura { get; set; }


        // Metodo para calcular el area de un Triangulo
        public override double CalcularArea()
        {
            var result = (Base * Altura) / 2;

            return result;
        }
    }
}
