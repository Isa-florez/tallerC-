using System;

class Program
{
    static void Main()
    {
        int op;

        Console.WriteLine("1. Consulta");
        Console.WriteLine("2. Laboratorio");
        Console.WriteLine("3. Rayos X");
        Console.WriteLine("4. Farmacia");
        Console.WriteLine("5. Salir");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Precio: 50");
                break;
            case 2:
                Console.WriteLine("Precio: 30");
                break;
            case 3:
                Console.WriteLine("Precio: 80");
                break;
            case 4:
                Console.WriteLine("Precio: 20");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
