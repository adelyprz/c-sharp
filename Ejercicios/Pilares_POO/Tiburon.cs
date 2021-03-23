using System;
public class Tiburon: Peces
{
    public Tiburon(string alimentacion, string habitad, string nombre)
    {
        Alimentacion = alimentacion;
        Habitad = habitad;
        Nombre = nombre;
    }

    public void metodo()
    {
        Console.WriteLine("Nadar Rapido");
        Console.WriteLine("Asechar");
    }
}