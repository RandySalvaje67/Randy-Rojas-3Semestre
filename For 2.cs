using System;
class Program
{
    static void Main()
    {
        int opcion;
        Console.WriteLine("1. Triangulo de *");
        Console.WriteLine("2. Suma del 1 al 100");
        Console.WriteLine("3. Suma y promedio de calificaciones");
        Console.WriteLine("Elige una opcion:");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                break;
            case 2:
                int suma = 0;
                for (int i = 1; i <= 100; i++)
                {
                    suma = suma + i;
                }
                Console.WriteLine("La suma es: " + suma);
                break;
            case 3:
                int cantidad;
                double calificacion;
                double total = 0;
                double promedio;
                Console.WriteLine("Cuantas calificaciones vas a capturar?");
                cantidad = int.Parse(Console.ReadLine());
                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine("Ingresa la calificacion " + i + ":");
                    calificacion = double.Parse(Console.ReadLine());
                    total = total + calificacion;
                }
                if (cantidad > 0)
                {
                    promedio = total / cantidad;
                    Console.WriteLine("Suma total: " + total);
                    Console.WriteLine("Promedio: " + promedio);
                }
                else
                {
                    Console.WriteLine("Cantidad invalida");
                }
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}
