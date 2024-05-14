using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_LSP.Ejercicio1
{
    public class Cuadrado : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return Base * (Altura + 1);
        }

    }
}
