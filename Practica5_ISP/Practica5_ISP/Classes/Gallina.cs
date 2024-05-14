using Practica5_ISP.Interfaces;



namespace Practica5_ISP.Classes
{
    public class Gallina : IAveCantar, IAveOviparo
    {
        public void Cantar()
        {
            Console.WriteLine("La Gallina puede cantar");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("La Gallina puede poner huevos.");
        }
    }
}
