using System;

class programa
{
    static void Main(string[] args)
    {
        int tempoDeViagem, velocidadeMedia;

        tempoDeViagem = int.Parse(Console.ReadLine());
        velocidadeMedia = int.Parse(Console.ReadLine());

        double distancia = tempoDeViagem * velocidadeMedia;
        double litros = distancia / 12;

        Console.WriteLine(litros.ToString("F3"));
    }
}