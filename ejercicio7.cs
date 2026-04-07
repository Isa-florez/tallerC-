using System;

class Program
{
    static double CalcularDosis(double peso, double dosisPorKg)
    {
        return peso * dosisPorKg;
    }

    static void Mostrar(string nombre, double dosis)
    {
        Console.WriteLine("Paciente: " + nombre);
        Console.WriteLine("Dosis: " + dosis);
    }

    static void Main()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Peso: ");
        double peso = double.Parse(Console.ReadLine());

        double dosis = CalcularDosis(peso, 2);
        Mostrar(nombre, dosis);
    }
}
