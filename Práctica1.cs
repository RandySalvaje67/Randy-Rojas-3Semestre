using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingresa una edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Ingresa una letra: ");
        char letra = char.Parse(Console.ReadLine());
        Console.Write("Ingresa un nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingresa una altura: ");
        float altura = float.Parse(Console.ReadLine());
        Console.Write("Ingresa el precio: ");
        double precio = double.Parse(Console.ReadLine());
        Console.Write("¿Esta activo? (true/false): ");
        bool activo = bool.Parse(Console.ReadLine());
        Console.WriteLine("\nDatos ingresados:");
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Letra: " + letra);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Precio: " + precio);
        Console.WriteLine("Activo: " + activo);
    }
}
