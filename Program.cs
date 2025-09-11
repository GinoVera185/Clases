// See https://aka.ms/new-console-template for more information
string miVariable;
int edad;

Console.WriteLine("Ingrese su nombre: ");
miVariable = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola soy {miVariable}, tengo {edad} años");