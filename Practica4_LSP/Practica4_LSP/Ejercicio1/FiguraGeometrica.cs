
namespace Practica4_LSP.Ejercicio1
{
    

    public class FiguraGeometrica
    {
        public virtual double Base { get; set; }
        public virtual double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }

   
}
