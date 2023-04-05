using System;

class programa
{
    public static void Main(string[] args)
    {
        int a, b, c, d, calc;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        calc = (a * b) - (c * d);

        Console.WriteLine("DIFERENCA = " + calc);
    }
}