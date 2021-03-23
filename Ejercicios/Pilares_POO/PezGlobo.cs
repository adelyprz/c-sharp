using System;
public class PezGlobo: Peces
{
    public PezGlobo(string habitad, string nombre)
    {
        Habitad = habitad;
        Nombre = nombre;
    }

    public void metodo()
    {
        Console.WriteLine("Inflarse");
    }
}