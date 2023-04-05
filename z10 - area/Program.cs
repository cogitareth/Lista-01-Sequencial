using System;

class programa
{
    static void Main(string[] args)
    {
        double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

        string[] valores = Console.ReadLine().Split(' ');

        a = double.Parse(valores[0]);
        b = double.Parse(valores[1]);
        c = double.Parse(valores[2]);

        triangulo = (a * c) / 2;
        circulo = 3.14159 * Math.Pow(c, 2);
        trapezio = ((a + b) * c) / 2;
        quadrado = b * b;
        retangulo = a * b;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
    }
}
