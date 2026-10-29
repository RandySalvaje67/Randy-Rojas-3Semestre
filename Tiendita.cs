using System;
class Program
{
    static void Main()
    {
        int opcion;
        Console.WriteLine("=====LA TIENDITA=====");
        Console.WriteLine("1. Tabla de precios por cantidad");
        Console.WriteLine("2. Ventas de la semana");
        Console.WriteLine("3. Total de piezas en promocion");
        Console.WriteLine("4. Salir");
        Console.WriteLine("Elige una opcion:");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                double precio;
                double costo;
                Console.WriteLine("Ingresa el precio unitario:");
                precio = double.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    costo = precio * i;
                    if (i >= 6)
                    {
                        costo = costo * 0.90;
                        Console.WriteLine(i + " pieza(s) = $" + costo.ToString("F2") + " (con descuento)");
                    }
                    else
                    {
                        Console.WriteLine(i + " pieza(s) = $" + costo.ToString("F2"));
                    }
                }
                break;
            case 2:
                double venta;
                double totalVentas = 0;
                double promedio;
                double mayor = 0;
                int diaMayor = 0;
                int diasMayores = 0;
                for (int i = 1; i <= 7; i++)
                {
                    Console.WriteLine("Venta del dia " + i + ":");
                    venta = double.Parse(Console.ReadLine());
                    totalVentas = totalVentas + venta;

                    if (i == 1 || venta > mayor)
                    {
                        mayor = venta;
                        diaMayor = i;
                    }

                    if (venta > 1000)
                    {
                        diasMayores++;
                    }
                }
                promedio = totalVentas / 7;
                Console.WriteLine("Total: $" + totalVentas.ToString("F2"));
                Console.WriteLine("Promedio: $" + promedio.ToString("F2"));
                Console.WriteLine("Venta mas alta: $" + mayor.ToString("F2") + " el dia " + diaMayor);
                Console.WriteLine("Dias con venta mayor a $1000: " + diasMayores);
                break;
            case 3:
                int n;
                int total = 0;
                int pares = 0;
                int impares = 0;
                long producto = 1;
                bool valido;
                char tipo;
                Console.WriteLine("Cuantos dias dura la promocion (1 a 20):");
                n = int.Parse(Console.ReadLine());
                valido = n >= 1 && n <= 20;
                if (valido)
                {
                    for (int dia = 1; dia <= n; dia++)
                    {
                        Console.WriteLine("Dia " + dia + ": se regalaron " + dia + " pieza(s)");

                        total = total + dia;
                        producto = producto * dia;

                        if (dia % 2 == 0)
                        {
                            pares++;
                            tipo = 'P';
                        }
                        else
                        {
                            impares++;
                            tipo = 'I';
                        }

                        if (tipo == 'P')
                        {
                            Console.WriteLine("Es par");
                        }
                        else
                        {
                            Console.WriteLine("Es impar");
                        }
                    }
                    Console.WriteLine("Total de piezas regaladas: " + total);
                    Console.WriteLine("Producto de los dias: " + producto);
                    Console.WriteLine("Dias pares: " + pares);
                    Console.WriteLine("Dias impares: " + impares);
                }
                else
                {
                    Console.WriteLine("Cantidad invalida");
                }
                break;
            case 4:
                Console.WriteLine("Gracias por usar los reportes de la tiendita");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}
