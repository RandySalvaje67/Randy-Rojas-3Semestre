using System;
class Program
{
    static void Main()
    {
        int opcion = 0;
        while (opcion != 6)
        {
            Console.WriteLine("===== CAJERO AUTOMATICO =====");
            Console.WriteLine("1. Convertir numero a binario");
            Console.WriteLine("2. Depositar billetes");
            Console.WriteLine("3. Validar NIP");
            Console.WriteLine("4. Analizar numero de cuenta");
            Console.WriteLine("5. Decodificar mensaje");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Elige una opcion:");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                {
                    int numero, residuo;
                    string binario = "";
                    Console.WriteLine("Ingresa un numero:");
                    numero = int.Parse(Console.ReadLine());
                    while (numero <= 0)
                    {
                        Console.WriteLine("Numero invalido, intenta de nuevo");
                        numero = int.Parse(Console.ReadLine());
                    }
                    int copia = numero;
                    while (copia > 0)
                    {
                        residuo = copia % 2;
                        binario = residuo + binario;
                        copia = copia / 2;
                    }

                    Console.WriteLine("Decimal: " + numero);
                    Console.WriteLine("Binario: " + binario);
                    break;
                }

                case 2:
                {
                    int billete = 1;
                    int total = 0;
                    int cantidad = 0;

                    while (billete != 0)
                    {
                        Console.WriteLine("Ingresa un billete (0 para terminar):");
                        billete = int.Parse(Console.ReadLine());

                        if (billete == 20 || billete == 50 || billete == 100 ||
                            billete == 200 || billete == 500 || billete == 1000)
                        {
                            total = total + billete;
                            cantidad++;
                        }
                        else if (billete != 0)
                        {
                            Console.WriteLine("Billete no valido, se rechaza");
                        }
                    }

                    Console.WriteLine("Billetes aceptados: " + cantidad);
                    Console.WriteLine("Total depositado: $" + total);
                    break;
                }

                case 3:
                {
                    int nip;
                    int intentos = 0;
                    int acceso = 0;

                    while (intentos < 3 && acceso == 0)
                    {
                        Console.WriteLine("Ingresa tu NIP:");

                        if (int.TryParse(Console.ReadLine(), out nip))
                        {
                            intentos++;

                            if (nip == 1234)
                            {
                                Console.WriteLine("Acceso concedido en el intento " + intentos);
                                acceso = 1;
                            }
                            else
                            {
                                Console.WriteLine("NIP incorrecto, te quedan " + (3 - intentos) + " intentos");
                            }
                        }
                        else
                        {
                            intentos++;
                            Console.WriteLine("Dato invalido");
                        }
                    }

                    if (acceso == 0)
                    {
                        Console.WriteLine("Tarjeta bloqueada");
                    }
                    break;
                }

                case 4:
                {
                    int cuenta, copia, digito;
                    int digitos = 0;
                    int suma = 0;
                    int invertido = 0;

                    Console.WriteLine("Ingresa tu numero de cuenta:");
                    cuenta = int.Parse(Console.ReadLine());

                    while (cuenta <= 0)
                    {
                        Console.WriteLine("Numero invalido, intenta de nuevo");
                        cuenta = int.Parse(Console.ReadLine());
                    }

                    copia = cuenta;

                    while (copia > 0)
                    {
                        digito = copia % 10;
                        digitos++;
                        suma = suma + digito;
                        invertido = invertido * 10 + digito;
                        copia = copia / 10;
                    }

                    Console.WriteLine("Cantidad de digitos: " + digitos);
                    Console.WriteLine("Suma de digitos: " + suma);

                    if (suma % 2 == 0)
                    {
                        Console.WriteLine("La suma es par");
                    }
                    else
                    {
                        Console.WriteLine("La suma es impar");
                    }

                    Console.WriteLine("Numero invertido: " + invertido);

                    if (cuenta == invertido)
                    {
                        Console.WriteLine("Es capicua");
                    }
                    else
                    {
                        Console.WriteLine("No es capicua");
                    }
                    break;
                }

                case 5:
                {
                    int codigo = 1;
                    int cantidad = 0;
                    int suma = 0;
                    double promedio = 0;
                    string mensaje = "";
                    char letra;

                    while (codigo != 0)
                    {
                        Console.WriteLine("Ingresa un codigo ASCII (0 para terminar):");
                        codigo = int.Parse(Console.ReadLine());

                        if (codigo >= 32 && codigo <= 126)
                        {
                            letra = (char)codigo;
                            mensaje = mensaje + letra;
                            cantidad++;
                            suma = suma + codigo;

                            if (codigo >= 65 && codigo <= 90)
                            {
                                Console.WriteLine(letra + " -> Mayuscula");
                            }
                            else if (codigo >= 97 && codigo <= 122)
                            {
                                Console.WriteLine(letra + " -> Minuscula");
                            }
                            else if (codigo >= 48 && codigo <= 57)
                            {
                                Console.WriteLine(letra + " -> Digito");
                            }
                            else
                            {
                                Console.WriteLine(letra + " -> Simbolo");
                            }
                        }
                        else if (codigo != 0)
                        {
                            Console.WriteLine("Codigo no valido, se rechaza");
                        }
                    }

                    if (cantidad > 0)
                    {
                        promedio = (double)suma / cantidad;
                    }

                    Console.WriteLine("Mensaje decodificado: " + mensaje);
                    Console.WriteLine("Caracteres aceptados: " + cantidad);
                    Console.WriteLine("Promedio de codigos: " + Math.Round(promedio, 2));
                    break;
                }
                case 6:
                    Console.WriteLine("Gracias por usar el cajero automatico");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.WriteLine();
        }
    }
}
