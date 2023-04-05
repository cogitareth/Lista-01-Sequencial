using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int horas = N / 3600;
        N %= 3600;
        int minutos = N / 60;
        int segundos = N % 60;

        Console.WriteLine(horas + ":" + minutos.ToString("00") + ":" + segundos.ToString("00"));
    }
}