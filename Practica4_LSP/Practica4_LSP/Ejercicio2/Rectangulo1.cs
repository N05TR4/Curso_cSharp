using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_LSP.Ejercicio2
{
    public class Rectangulo1 : FiguraGeometrica1
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo1(double _base, double _altura) 
        { 
            Base = _base;
            Altura = _altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
