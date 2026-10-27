using System;
class Program
{
    static void Main()
    {
        int opcion;
        Console.WriteLine("1-. Tablas de multiplicar");
        Console.WriteLine("2-. Numeros pares e impares");
        Console.WriteLine("3-. Cuadrado de *");
        Console.WriteLine("Elige una opcion:");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Tabla del " + i);

                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + (i * j));
                    }
                    Console.WriteLine();
                }
                break;
            case 2:
                for (int i = 0; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " Es par");
                    }
                    else
                    {
                        Console.WriteLine(i + " Es impar");
                    }
                }
                break;
            case 3:
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}



