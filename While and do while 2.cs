using System;
class Program
{
    static void Main()
    {
        int numero;
        int i = 1;
        Console.WriteLine("Cuantos asteriscos quieres por lado?");
        numero = int.Parse(Console.ReadLine());
        do
        {
            int j = 1;
            do
            {
                Console.Write("*");
                j++;
            } while (j <= numero);
            Console.WriteLine();
            i++;
        } while (i <= numero);
    }
}
