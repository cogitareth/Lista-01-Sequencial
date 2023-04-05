using System;

class programa
{
    static void Main(string[] args)
    {
        int x;
        float y, z;

        x = int.Parse(Console.ReadLine());
        y = float.Parse(Console.ReadLine());

        z = x / y;

        Console.WriteLine(z.ToString("F3") + " km/l");
    }
}
