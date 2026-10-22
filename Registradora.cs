using System;
class Program
{
    static void Main()
    {
        int opcion;

        Console.WriteLine("CAJA REGISTRADORA");
        Console.WriteLine("1. Calcular cambio");
        Console.WriteLine("2. Aplicar descuento");
        Console.WriteLine("3. Validar fecha");
        Console.WriteLine("4. Folio capicua");
        Console.WriteLine("5. Redondeo e inventario");
        Console.WriteLine("6. Salir");
        Console.Write("Elige una opcion: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                int precio, pago, cambio;

                Console.Write("Precio: ");
                precio = int.Parse(Console.ReadLine());

                Console.Write("Pago: ");
                pago = int.Parse(Console.ReadLine());

                cambio = pago - precio;

                if (cambio < 0)
                    Console.WriteLine("Pago insuficiente");
                else if (cambio == 0)
                    Console.WriteLine("Pago exacto");
                else
                    Console.WriteLine("Cambio: $" + cambio);
                break;

            case 2:
                double subtotal, total;
                char tipo;

                Console.Write("Subtotal: ");
                subtotal = double.Parse(Console.ReadLine());

                Console.Write("Tipo E, D o G: ");
                tipo = char.Parse(Console.ReadLine());

                if (tipo == 'E' || tipo == 'e')
                    total = subtotal - subtotal * 15 / 100;
                else if (tipo == 'D' || tipo == 'd')
                    total = subtotal - subtotal * 10 / 100;
                else if (tipo == 'G' || tipo == 'g')
                    total = subtotal;
                else
                    total = -1;

                if (total >= 0)
                    Console.WriteLine("Total: $" + total);
                else
                    Console.WriteLine("Tipo incorrecto");
                break;

            case 3:
                int dia, mes, año, dias = 0;
                bool bisiesto;

                Console.Write("Dia: ");
                dia = int.Parse(Console.ReadLine());

                Console.Write("Mes: ");
                mes = int.Parse(Console.ReadLine());

                Console.Write("Año: ");
                año = int.Parse(Console.ReadLine());

                bisiesto = (año % 4 == 0 && año % 100 != 0)
                           || año % 400 == 0;

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        dias = 31;
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        dias = 30;
                        break;

                    case 2:
                        dias = 28;

                        if (bisiesto)
                            dias = 29;
                        break;
                }

                if (año > 0 && mes >= 1 && mes <= 12 &&
                    dia >= 1 && dia <= dias)
                    Console.WriteLine("Fecha valida");
                else
                    Console.WriteLine("Fecha invalida");

                if (bisiesto)
                    Console.WriteLine("Año bisiesto");
                else
                    Console.WriteLine("Año no bisiesto");
                break;

            case 4:
                int folio, a, b, c, d, suma, producto;

                Console.Write("Folio de 4 digitos: ");
                folio = int.Parse(Console.ReadLine());

                if (folio >= 1000 && folio <= 9999)
                {
                    a = folio / 1000;
                    b = folio / 100 % 10;
                    c = folio / 10 % 10;
                    d = folio % 10;

                    if (a == d && b == c)
                        Console.WriteLine("Es capicua");
                    else
                        Console.WriteLine("No es capicua");

                    suma = a + b + c + d;
                    producto = a * b * c * d;

                    Console.WriteLine("Suma: " + suma);
                    Console.WriteLine("Producto: " + producto);

                    if (suma % 2 == 0)
                        Console.WriteLine("Suma par");
                    else
                        Console.WriteLine("Suma impar");
                }
                else
                    Console.WriteLine("Folio incorrecto");
                break;

            case 5:
                double numero;
                int esperadas, contadas, diferencia;

                Console.Write("Precio decimal: ");
                numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Precio redondeado: " +
                    (int)(numero + 0.5));

                Console.Write("Piezas esperadas: ");
                esperadas = int.Parse(Console.ReadLine());

                Console.Write("Piezas contadas: ");
                contadas = int.Parse(Console.ReadLine());

                diferencia = contadas - esperadas;

                if (diferencia == 0)
                    Console.WriteLine("Inventario correcto");
                else if (diferencia < 0)
                    Console.WriteLine("Faltan " + (diferencia * -1) + " piezas");
                else
                    Console.WriteLine("Sobran " + diferencia + " piezas");
                break;

            case 6:
                Console.WriteLine("Gracias por usar la registradora");
                break;

            default:
                Console.WriteLine("Opcion no encontrada");
                break;
        }
    }
}
