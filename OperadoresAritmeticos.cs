{
//operadores aritmeticos
/*
+
-
*
/
*/
double numeroUno = 15;
double numeroDos = 30;
Console.WriteLine(numeroUno+numeroDos);
Console.WriteLine(numeroUno-numeroDos);
Console.WriteLine(numeroUno*numeroDos);
Console.WriteLine(numeroUno/numeroDos);
Console.WriteLine(numeroUno%numeroDos);

//circulo
double radio;
Console.WriteLine("Ingresa el radio:");
radio = double.Parse(Console.ReadLine());
Console.WriteLine(3.1416 * radio * radio);

//cuadrado
double lado;
Console.WriteLine("Ingresa el lado:");
lado = double.Parse(Console.ReadLine());
Console.WriteLine(lado * lado);

//rectangulo
double baseRectangulo;
double altura;
Console.WriteLine("Ingresa la base:");
baseRectangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la altura:");
altura = double.Parse(Console.ReadLine());
Console.WriteLine(baseRectangulo * altura);
}
