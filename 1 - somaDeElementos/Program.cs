using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string nome;
        double salarioFixo, totalVendas, totalReceber;

        nome = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine());
        totalVendas = double.Parse(Console.ReadLine());

        totalReceber = salarioFixo + (totalVendas * 0.15);

        Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2"));
    }
}