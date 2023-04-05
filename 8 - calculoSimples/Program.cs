using System;

class programa
{
    static void Main(string[] args)
    {
        int cod1, cod2, qtd1, qtd2;
        double valor1, valor2, total;

        string[] valores1 = Console.ReadLine().Split(' ');
        cod1 = int.Parse(valores1[0]);
        qtd1 = int.Parse(valores1[1]);
        valor1 = int.Parse(valores1[2]);

        string[] valores2 = Console.ReadLine().Split(' ');
        cod2 = int.Parse(valores2[0]);
        qtd2 = int.Parse(valores2[1]);
        valor2 = double.Parse(valores2[2]);

        total = (qtd1 * valor1) + (qtd2 * valor2);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }
}
