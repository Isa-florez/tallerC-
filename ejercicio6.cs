using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[5];
        int[] cantidades = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Medicamento: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Cantidad: ");
            cantidades[i] = int.Parse(Console.ReadLine());
        }

        int menor = cantidades[0];
        string nombreMenor = nombres[0];

        Console.WriteLine("\nInventario:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(nombres[i] + " - " + cantidades[i]);
            
            if (cantidades[i] < menor)
            {
                menor = cantidades[i];
                nombreMenor = nombres[i];
            }
        }

        Console.WriteLine("Menor stock: " + nombreMenor);
    }
}
