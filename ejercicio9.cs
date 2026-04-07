using System;

class Paciente
{
    private string nombre;
    private int edad;

    public void SetNombre(string n)
    {
        nombre = n;
    }

    public void SetEdad(int e)
    {
        edad = e;
    }

    public void Mostrar()
    {
        Console.WriteLine(nombre + " - " + edad);
    }
}

class Program
{
    static void Main()
    {
        Paciente p1 = new Paciente();
        p1.SetNombre("Ana");
        p1.SetEdad(20);

        Paciente p2 = new Paciente();
        p2.SetNombre("Luis");
        p2.SetEdad(30);

        p1.Mostrar();
        p2.Mostrar();
    }
}
