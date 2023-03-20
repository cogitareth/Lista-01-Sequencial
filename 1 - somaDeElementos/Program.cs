using System;

class Programa
{
    static void Main(string[] args)
    {
        int A, B, SOMA;

        Console.Write("Digite o valor de A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        B = int.Parse(Console.ReadLine());

        SOMA = A + B;

        Console.WriteLine("SOMA = " + SOMA);
    }
}