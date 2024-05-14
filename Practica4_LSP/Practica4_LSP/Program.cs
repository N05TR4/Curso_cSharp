using Practica4_LSP.Ejercicio1;
using Practica4_LSP.Ejercicio2;




// Ejercicio #1

Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 4 };
Cuadrado cuadrado = new Cuadrado { Base = 4 };

// Calcular y mostrar áreas
Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea()); // Debería ser 20
Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea()); // Incorrecta


// ejercicio #2

Rectangulo1 rectangulo1 = new Rectangulo1(5, 4);
Cuadrado1 cuadrado1 = new Cuadrado1(4);

// Calcular y mostrar áreas
Console.WriteLine("Área del rectángulo: " + rectangulo1.CalcularArea()); // Debería ser 20
Console.WriteLine("Área del cuadrado: " + cuadrado1.CalcularArea()); // Debería ser 16
