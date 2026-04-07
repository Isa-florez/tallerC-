using System;
using System.IO;

class Program
{
    static void Main()
    {
        string usuario = "admin";
        string pass = "1234";

        Console.Write("Usuario: ");
        string u = Console.ReadLine();

        Console.Write("Password: ");
        string p = Console.ReadLine();

        if (u == usuario && p == pass)
        {
            int op;

            do
            {
                Console.WriteLine("\n1. Registrar cita");
                Console.WriteLine("2. Ver citas");
                Console.WriteLine("3. Salir");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    File.AppendAllText("citas.txt", nombre + "\n");
                }
                else if (op == 2)
                {
                    if (File.Exists("citas.txt"))
                    {
                        string texto = File.ReadAllText("citas.txt");
                        Console.WriteLine(texto);
                    }
                }

            } while (op != 3);
        }
        else
        {
            Console.WriteLine("Login incorrecto");
        }
    }
}
