using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Numero historia: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Correcto: " + num);
        }
        catch
        {
            Console.WriteLine("Error: ingrese solo numeros");
        }
    }
}
