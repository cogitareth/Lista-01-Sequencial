using System;

class programa
{
    public static void Main(string[] args)
    {
       int n, horasTrabalhadas; 
       double valorPorHoras, salario;

        n = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        valorPorHoras = double.Parse(Console.ReadLine());

        salario = (horasTrabalhadas * valorPorHoras);

        Console.WriteLine("NUMBER = " + n);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
    }
}