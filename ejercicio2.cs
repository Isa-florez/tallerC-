using System;

class Program
{
    static void Main()
    {
        double temp, presion;

        Console.Write("Temperatura: ");
        temp = double.Parse(Console.ReadLine());

        Console.Write("Presion: ");
        presion = double.Parse(Console.ReadLine());

        if (temp > 39 || presion > 180)
        {
            Console.WriteLine(" CRITICO");
        }
        else if (temp > 38 || presion > 140)
        {
            Console.WriteLine(" URGENTE");
        }
        else
        {
            Console.WriteLine("ESTABLE");
        }
    }
}
