using System;
using System.Net;

class Programa
{
    static void Main(string[] args)
    {
        double A, B, C, MEDIA;

        Console.WriteLine("Digite a média da primeira matéria: ");
        A = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a média da segunda matéria: ");
        B = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a média da terceira matéria: ");
        C = double.Parse(Console.ReadLine());

        MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 100;

        Console.WriteLine("MEDIA = " + MEDIA);
    }
}