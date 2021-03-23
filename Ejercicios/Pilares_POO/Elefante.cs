using System;
public class Elefante: Mamiferos
{
    public string Trompa { get; set; }
    public string Orden { get; set; }

    public Elefante(string trompa, string orden, string nombre, int edad, int numPatas, string desplazamiento)
    {   
        Trompa = trompa;
        Orden = orden;
        Nombre = nombre;
        Edad = edad;
        NumPatas = numPatas;
        Desplazamiento = desplazamiento;
    }

    public void metodo()
    {
        Console.WriteLine("Caminar");
    }
}