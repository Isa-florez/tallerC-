using System;

class Program
{
    static void Main()
    {
        int turno;
        string continuar = "S";

        while (continuar == "S")
        {
            Console.Write("Ingrese turno: ");
            turno = int.Parse(Console.ReadLine());

            if (turno <= 0)
            {
                Console.WriteLine("Error, turno invalido");
            }
            else
            {
                Console.WriteLine("Turno registrado");
            }

            Console.Write("¿Continuar? (S/N): ");
            continuar = Console.ReadLine();
        }
    }
}
