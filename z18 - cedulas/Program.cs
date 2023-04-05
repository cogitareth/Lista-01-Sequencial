using System;

class Program
{
    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        int nota, resto;

        Console.WriteLine(valor);

        nota = valor / 100;
        Console.WriteLine($"{nota} nota(s) de R$ 100,00");
        resto = valor % 100;

        nota = resto / 50;
        Console.WriteLine($"{nota} nota(s) de R$ 50,00");
        resto = resto % 50;

        nota = resto / 20;
        Console.WriteLine($"{nota} nota(s) de R$ 20,00");
        resto = resto % 20;

        nota = resto / 10;
        Console.WriteLine($"{nota} nota(s) de R$ 10,00");
        resto = resto % 10;

        nota = resto / 5;
        Console.WriteLine($"{nota} nota(s) de R$ 5,00");
        resto = resto % 5;

        nota = resto / 2;
        Console.WriteLine($"{nota} nota(s) de R$ 2,00");
        resto = resto % 2;

        Console.WriteLine($"{resto} nota(s) de R$ 1,00");
    }
}