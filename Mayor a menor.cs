using System;
class Program
{
    static void Main()
    {
        Random rd = new Random();
        int numero1 = rd.Next(0,10);
        int numero2 = rd.Next(0, 10);
        int numero3 = rd.Next(0,10);
        Console.WriteLine("Numeros aleatorios:");
        Console.WriteLine(numero1);
        Console.WriteLine(numero2);
        Console.WriteLine(numero3);
        Console.WriteLine("Ordenados de menor a mayor:");
        if (numero1 < numero2 && numero1 < numero3)
        {
        if (numero2 < numero3)
            {
              Console.WriteLine(numero1);
              Console.WriteLine(numero2);
              Console.WriteLine(numero3);
            }
     else
            {
              Console.WriteLine(numero1);
              Console.WriteLine(numero3);
              Console.WriteLine(numero2);
            }
        }
     else if (numero2 < numero1 && numero2 < numero3)
        {
        if (numero1 < numero3)
            {
              Console.WriteLine(numero2);
              Console.WriteLine(numero1);
              Console.WriteLine(numero3);
            }
     else
            {
              Console.WriteLine(numero2);
              Console.WriteLine(numero3);
              Console.WriteLine(numero1);
            }
        }
     else
       {
        if (numero1 < numero2)
            {
              Console.WriteLine(numero3);
              Console.WriteLine(numero1);
              Console.WriteLine(numero2);
            }
            else
            {
              Console.WriteLine(numero3);
              Console.WriteLine(numero2);
              Console.WriteLine(numero1);
            }
        }
    }

}
