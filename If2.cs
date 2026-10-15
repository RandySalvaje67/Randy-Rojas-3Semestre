using System;
class Program
{
    static void Main()
    {
        // Ejercicio 1
        int numero;
        Console.WriteLine("Ejercicio 1: Numero mayor a 100");
        Console.WriteLine("Ingresa un numero:");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 100)
        {
            Console.WriteLine("El numero es mayor que 100");
        }

        // Ejercicio 2
        double compra;
        Console.WriteLine("Ejercicio 2: Envio gratis");
        Console.WriteLine("Ingresa el monto de la compra:");
        compra = Convert.ToDouble(Console.ReadLine());
        if (compra >= 500)
        {
            Console.WriteLine("Tienes envio gratis");
        }
        Console.WriteLine("Total: " + compra);

        // Ejercicio 3
        int numero3;
        Console.WriteLine("Ejercicio 3: Multiplo de 5");
        Console.WriteLine("Ingresa un numero:");
        numero3 = Convert.ToInt32(Console.ReadLine());
        if (numero3 % 5 == 0)
        {
            Console.WriteLine("El numero es multiplo de 5");
        }

        // Ejercicio 4
        int numero1;
        int numero2;
        Console.WriteLine("Ejercicio 4: Mayor de dos numeros");
        Console.WriteLine("Ingresa el primer numero:");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero:");
        numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > numero2)
        {
            Console.WriteLine("El mayor es: " + numero1);
        }
        else
        {
            Console.WriteLine("El mayor es: " + numero2);
        }

        // Ejercicio 5
        int numero5;
        Console.WriteLine("Ejercicio 5: Positivo o negativo");
        Console.WriteLine("Ingresa un numero:");
        numero5 = Convert.ToInt32(Console.ReadLine());
        if (numero5 >= 0)
        {
            Console.WriteLine("El numero es positivo o cero");
        }
        else
        {
            Console.WriteLine("El numero es negativo");
        }

        // Ejercicio 6
        double saldo;
        double compra6;
        Console.WriteLine("Ejercicio 6: Saldo suficiente");
        Console.WriteLine("Ingresa el saldo de tu tarjeta:");
        saldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el monto de la compra:");
        compra6 = Convert.ToDouble(Console.ReadLine());
        if (saldo >= compra6)
        {
            Console.WriteLine("Compra realizada");
            Console.WriteLine("Saldo restante: " + (saldo - compra6));
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }
}
