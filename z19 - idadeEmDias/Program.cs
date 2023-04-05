using System;

class Program
{
    static void Main(string[] args)
    {
        int idadeEmDias = int.Parse(Console.ReadLine());

        int anos = idadeEmDias / 365;
        idadeEmDias %= 365;

        int meses = idadeEmDias / 30;
        idadeEmDias %= 30;

        int dias = idadeEmDias;

        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");
    }
}