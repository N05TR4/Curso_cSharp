

namespace Practica4_LSP.Ejercicio1
{
    // Clase derivada Rectangulo
    public class Rectangulo : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
