using System;

class Program
{
    static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine());

        int notas100 = (int)(valor / 100);
        valor -= notas100 * 100;

        int notas50 = (int)(valor / 50);
        valor -= notas50 * 50;

        int notas20 = (int)(valor / 20);
        valor -= notas20 * 20;

        int notas10 = (int)(valor / 10);
        valor -= notas10 * 10;

        int notas5 = (int)(valor / 5);
        valor -= notas5 * 5;

        int notas2 = (int)(valor / 2);
        valor -= notas2 * 2;

        int moedas100 = (int)(valor / 1);
        valor -= moedas100 * 1;

        int moedas50 = (int)(valor / 0.5);
        valor -= moedas50 * 0.5;

        int moedas25 = (int)(valor / 0.25);
        valor -= moedas25 * 0.25;

        int moedas10 = (int)(valor / 0.1);
        valor -= moedas10 * 0.1;

        int moedas5 = (int)(valor / 0.05);
        valor -= moedas5 * 0.05;

        int moedas1 = (int)Math.Round(valor / 0.01);

        Console.WriteLine("NOTAS:");
        Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine(moedas100 + " moeda(s) de R$ 1.00");
        Console.WriteLine(moedas50 + " moeda(s) de R$ 0.50");
        Console.WriteLine(moedas25 + " moeda(s) de R$ 0.25");
        Console.WriteLine(moedas10 + " moeda(s) de R$ 0.10");
        Console.WriteLine(moedas5 + " moeda(s) de R$ 0.05");
        Console.WriteLine(moedas1 + " moeda(s) de R$ 0.01");
    }
}