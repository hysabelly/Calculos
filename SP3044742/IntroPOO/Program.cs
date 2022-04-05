// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Quadrado q1 = new Quadrado(10.0);
Quadrado q2 = new Quadrado(5.5);

q2.Lado = 5.3;

Console.WriteLine(q1.Lado);
Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);

Console.WriteLine(q2.Lado);
Console.WriteLine(q2.Area);
Console.WriteLine(q2.Perimetro);