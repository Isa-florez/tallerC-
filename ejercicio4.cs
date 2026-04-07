using System;

class Program
{
    static void Main()
    {
        int total = 0;

        for (int i = 1; i <= 7; i++)
        {
            Console.Write("Vacunas dia " + i + ": ");
            int v = int.Parse(Console.ReadLine());
            total += v;
        }

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Promedio: " + total / 7.0);
    }
}
