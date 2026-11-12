using System;
class Program
{
    static void Main()
    {
        int numero;
        int i = 1;
        Console.WriteLine("Cuantos asteriscos quieres por lado?");
        numero = int.Parse(Console.ReadLine()) 
        while (i <= numero)
        {
            int j = 1;
            while (j <= numero)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }
}
