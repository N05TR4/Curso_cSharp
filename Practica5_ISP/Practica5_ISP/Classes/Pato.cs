using Practica5_ISP.Interfaces;



namespace Practica5_ISP.Classes
{
    public class Pato : IAveVolar, IAveCantar, IAveOviparo, IAveNadar
    {
        public void Volar()
        {
            Console.WriteLine("El pato puede volar.");
        }

        public void Cantar()
        {
            Console.WriteLine("El pato puede cantar.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pato puede poner huevos.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato puede nadar.");
        }
    }
}
