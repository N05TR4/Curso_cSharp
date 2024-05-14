using Practica5_ISP.Interfaces;


namespace Practica5_ISP.Classes
{
    public class Aguila : IAveVolar, IAveCantar, IAveOviparo, IAveCazadora
    {
        public void Volar()
        {
            Console.WriteLine("El águila puede volar.");
        }

        public void Cantar()
        {
            Console.WriteLine("El águila puede cantar");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El águila puede poner huevos.");
        }

        public void Cazar()
        {
            Console.WriteLine("El águila puede cazar.");
        }

    }
}
