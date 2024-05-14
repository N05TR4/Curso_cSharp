using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_LSP.Ejercicio2
{
    public class Cuadrado1 : FiguraGeometrica1
    {
        public double Lado { get; set; }

        public Cuadrado1(double _lado) 
        {
            Lado = _lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
