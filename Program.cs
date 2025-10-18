double a, b, c, d, x1;
double x2;
Console.Write("Digite o valor de [a]...: ");
a = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o valor de [b]...: ");
b = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o valor de [c]...: ");
c = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"Equação informada é ({a})x + ({b}) + ({c})");

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Essa não é uma equação de segundo grau, porque [a] é igual 0");
}
else
{
    d = Math.Pow(b, 2) - 4 * a * c;
    Console.WriteLine($"delta igual a {d:N2}");

    if (d < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Write("Não possui raíz real, pois a raíz é negativa.");
    }
    else
    {
        x1 = (-b + Math.Sqrt(d)) / (2 * a);

        if (d == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" x igual a {x1:N2}");
        }
            else{
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" x' igual a {x1:N2}");
                Console.WriteLine($" x'' igual a {x2:N2}");
                }

    }


}

Console.ResetColor();

Console.Clear();
