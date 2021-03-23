using System;
public class Delfin: Mamiferos
{
    public string Aletas { get; set; }

    public Delfin(string aletas, string nombre, int edad, string desplazamiento)
    {
        Aletas = aletas;
        Nombre = nombre;
        Edad = edad;
        Desplazamiento = desplazamiento;
    }

    public void metodo()
    {
        Console.WriteLine("Nadar");
    }
}