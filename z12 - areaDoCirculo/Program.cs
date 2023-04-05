using System;

class programa
{
    static void Main(string[] args)
    {
        double raio, area;
        double pi = 3.14159;

        raio = double.Parse(Console.ReadLine());
        area = pi * Math.Pow(raio, 2);

        Console.WriteLine("A=" + area.ToString("F4"));
    }
}