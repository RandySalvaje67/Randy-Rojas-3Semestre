using System;
class Program
{
    static void Main()
    {
        // Ejercicio 7
        Console.WriteLine("--- Ejercicio 7 ---");
        Console.Write("Ingresa una calificacion (0 al 100): ");
        int calificacion = int.Parse(Console.ReadLine());
        if (calificacion < 0 && calificacion > 100)
        {
            Console.WriteLine("Calificacion no valida");
        }
        else if (calificacion >= 90)
        {
            Console.WriteLine("A");
        }
        else if (calificacion >= 80)
        {
            Console.WriteLine("B");
        }
        else if (calificacion >= 70)
        {
            Console.WriteLine("C");
        }
        else if (calificacion >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        Console.WriteLine(); // Linea en blanco para separar

        // Ejercicio 8
        Console.WriteLine("---Ejercicio 8---");
        Console.Write("Ingresa un numero del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());
        if (dia == 1)
        {
            Console.WriteLine("Lunes");
        }
        else if (dia == 2)
        {
            Console.WriteLine("Martes");
        }
        else if (dia == 3)
        {
            Console.WriteLine("Miercoles");
        }
        else if (dia == 4)
        {
            Console.WriteLine("Jueves");
        }
        else if (dia == 5)
        {
            Console.WriteLine("Viernes");
        }
        else if (dia == 6)
        {
            Console.WriteLine("Sabado");
        }
        else if (dia == 7)
        {
            Console.WriteLine("Domingo");
        }
        else
        {
            Console.WriteLine("Numero no valido");
        }
        Console.WriteLine();

        // Ejercicio 9
        Console.WriteLine("---Ejercicio 9---");
        Console.Write("Ingresa la temperatura: ");
        int temp = int.Parse(Console.ReadLine());
        if (temp < 0)
        {
            Console.WriteLine("Congelante");
        }
        else if (temp <= 14)
        {
            Console.WriteLine("Frio");
        }
        else if (temp <= 24)
        {
            Console.WriteLine("Templado");
        }
        else if (temp <= 34)
        {
            Console.WriteLine("Caluroso");
        }
        else
        {
            Console.WriteLine("Muy caluroso");
        }
    }
}
