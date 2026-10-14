using System;
class Program
{
static void Main()
{
// Ejercicio 1
int edad;
    Console.WriteLine("Ejercicio 1: Mayor de edad");
    Console.WriteLine("Escribe tu edad:");
    edad = int.Parse(Console.ReadLine());
    if (edad >= 18)
    {
        Console.WriteLine("Eres mayor de edad");
    }
    else
    {
        Console.WriteLine("Eres menor de edad");
    }

    // Ejercicio 2
    double compra;
    Console.WriteLine("\nEjercicio 2: Descuento");
    Console.WriteLine("Escribe el total de la compra:");
    compra = double.Parse(Console.ReadLine());
    if (compra > 1000)
    {
        compra = compra * 0.90;
        Console.WriteLine("Total con descuento: " + compra);
    }
    else
    {
        Console.WriteLine("Total sin descuento: " + compra);
    }
    Console.WriteLine("Gracias por su compra");

    // Ejercicio 3
    int numero;
    Console.WriteLine("\nEjercicio 3: Valor absoluto");
    Console.WriteLine("Escribe un numero:");
    numero = int.Parse(Console.ReadLine());
    if (numero < 0)
    {
        Console.WriteLine("El numero es negativo");
        Console.WriteLine("Valor absoluto: " + (numero * -1));
    }
    else
    {
        Console.WriteLine("El numero no es negativo");
    }

    // Ejercicio 4
    int num;
    Console.WriteLine("\nEjercicio 4: Par o impar");
    Console.WriteLine("Escribe un numero:");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine("El numero es par");
    }
    else
    {
        Console.WriteLine("El numero es impar");
    }

    // Ejercicio 5
    double calificacion;
    Console.WriteLine("\nEjercicio 5: Aprobado o reprobado");
    Console.WriteLine("Escribe tu calificacion:");
    calificacion = double.Parse(Console.ReadLine());
    if (calificacion >= 6)
    {
        Console.WriteLine("Estas aprobado");
    }
    else
    {
        Console.WriteLine("Estas reprobado :/");
    }

    // Ejercicio 6
    string password = "67";
    string respuesta;
    Console.WriteLine("\nEjercicio 6: Contraseña");
    Console.WriteLine("Escribe la contraseña:");
    respuesta = Console.ReadLine();
    if (respuesta == password)
    {
        Console.WriteLine("Acceso concedido");
    }
    else
    {
        Console.WriteLine("Acceso denegado");
    }
}

}
