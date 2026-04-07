using System;

class Program
{
    static void Main()
    {
        string nombre;
        int edad;
        double peso, estatura;
        char seguro;

        Console.Write("Nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Edad: ");
        edad = int.Parse(Console.ReadLine());

        Console.Write("Peso (kg): ");
        peso = double.Parse(Console.ReadLine());

        Console.Write("Estatura (m): ");
        estatura = double.Parse(Console.ReadLine());

        Console.Write("¿Tiene seguro? (S/N): ");
        seguro = char.Parse(Console.ReadLine());

        double imc = peso / (estatura * estatura);

        Console.WriteLine("\n--- FICHA MEDICA ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("IMC: " + imc);
    }
}
