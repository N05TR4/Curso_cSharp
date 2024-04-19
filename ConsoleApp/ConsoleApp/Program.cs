using ConsoleApp;


public class Program
{
    static void Main(string[] args)
    {

        // Creación de objetos Persona
        Persona persona1 = new Persona("San Pedro", 25, "Santo Domingo");
        Persona persona2 = new Persona("María", 30, "San Cristobal");

        // Mostrar información de las personas
        Console.WriteLine("Información de las personas:");
        persona1.MostrarInformacion();
        persona2.MostrarInformacion();
        Console.WriteLine();

        // Calcular edad en años
        Console.WriteLine($"La edad de {persona1.Nombre} en años: {persona1.CalcularEdadEnAnnos()} años");
        Console.WriteLine($"La edad de {persona2.Nombre} en años: {persona2.CalcularEdadEnAnnos()} años");
        Console.WriteLine();

        // Creación de objetos Estudiante
        Estudiante estudiante1 = new Estudiante("Carlos", 20, "Santiago", "Ingeniería Informática", "12345");
        Estudiante estudiante2 = new Estudiante("Laura", 22, "San Juan", "Medicina", "67890");

        // Mostrar información de los estudiantes
        Console.WriteLine("Información de los estudiantes:");
        estudiante1.MostrarInformacionEstudiante();
        Console.WriteLine();
        estudiante2.MostrarInformacionEstudiante();
        Console.WriteLine();

        // Creación de objetos de Figura
        Figura rectangulo = new Rectangulo() { Base = 5, Altura = 10 };
        Figura circulo = new Circulo() { Radio = 3 };
        Figura triangulo = new Triangulo() { Base = 4, Altura = 6 };

        // Cálculo de área y mostrar resultado
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());
        Console.WriteLine();
        Console.WriteLine("Programa Finalizado ...");
    }

}


