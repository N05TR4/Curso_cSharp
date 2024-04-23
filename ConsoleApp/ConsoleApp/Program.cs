using ConsoleApp;


public class Program
{
    static void Main(string[] args)
    {

       
        // Creación de objetos Estudiante
        Persona estudiante1 = new Estudiante("Carlos", 20, "Santiago", "Ingeniería Informática", "12345");
        Estudiante estudiante2 = new Estudiante("Laura", 22, "San Juan", "Medicina", "67890");

        // Calcular edad en años
        Console.WriteLine($"Por favor, la fecha de nacimiento de el estudiante {estudiante1.Nombre} (formato: dd/mm/aaaa):");
        string fecha1 = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Por favor, la fecha de nacimiento de la estudiante {estudiante2.Nombre} (formato: dd/mm/aaaa):");
        string fecha2 = Console.ReadLine();
        Console.WriteLine();


        // Mostrar información de los estudiantes
        Console.WriteLine("Información de los estudiantes:");

        //Estudiante #1
        estudiante1.MostrarInformacion();

        if (DateTime.TryParseExact(fecha1, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
        {
            Console.WriteLine($"El estudiante {estudiante1.Nombre} tiene {estudiante1.CalcularEdad(fechaNacimiento)} años de Edad");
        }
        else
        {
            Console.WriteLine("Formato incorrecto ...");
        }

        Console.WriteLine();

        //Estudiante #2
        estudiante2.MostrarInformacion();

        if (DateTime.TryParseExact(fecha2, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento2))
        {
            Console.WriteLine($"La estudiante {estudiante2.Nombre} tiene {estudiante2.CalcularEdad(fechaNacimiento2)} años de Edad");
        }
        else
        {
            Console.WriteLine("Formato incorrecto ...");
        }

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


