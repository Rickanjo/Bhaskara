// Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.
Console.WriteLine("--- calculadora de Bhaskara ---");

Console.Write("Digite o valor de 'a'......:");
double a = double.Parse(Console.ReadLine()!);

if (a == 0) {
    Console.WriteLine("\nNão é uma equação de segundo grau.");
    return;
}

Console.Write("Digite o valor de 'b'......:");
double b = double.Parse(Console.ReadLine()!);

Console.Write("Digite o valor de 'c'......:");
double c = double.Parse(Console.ReadLine()!);

double delta = Math.Pow(b, 2) - 4 * a *c;

if (delta < 0) {
    Console.WriteLine($"\nComo delta = {delta} não existem raízes reais.");
    return;
}

Double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
Double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine("\nAs raízes são:");
Console.WriteLine($"x1 = {x1:F2}");
 Console.WriteLine($"x2 = {x2:F2}");
