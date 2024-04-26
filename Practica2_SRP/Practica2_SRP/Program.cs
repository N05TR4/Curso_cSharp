using Practica2_SRP.Class;



Console.WriteLine("Hello, World!");
Console.WriteLine();

Persona persona = new Persona("Jose Alberto", 23, "San Cristobal", "jose@gmail.com");

Imprimir impro = new Imprimir(persona);

Email email = new Email(persona);

impro.ImprimiData();


Console.WriteLine();

email.EnviarCorreoElectronico("Hola este es mi primer correo");






