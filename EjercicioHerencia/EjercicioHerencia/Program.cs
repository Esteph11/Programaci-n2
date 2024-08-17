using EjercicioHerencia;
using System;

double baseRectangulo, alturaRectangulo, ladoCuadrado;

Console.WriteLine("Figuras geométricas");
Console.WriteLine();
Console.WriteLine("Ingrese la base del rectángulo:");
baseRectangulo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectángulo:");
alturaRectangulo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el lado del cuadrado:");
ladoCuadrado = Convert.ToDouble(Console.ReadLine());

Calcular calcular = new Calcular(baseRectangulo, alturaRectangulo, ladoCuadrado);

calcular.imprimir();
Console.WriteLine();
Console.ReadKey();