using System;
public class Perro: Mamiferos
{
    public string Raza { get; set; }
    public Perro(string raza, string nombre, int edad, int numPatas, string desplazamiento)
    {   
        Raza = raza;
        Nombre = nombre;
        Edad = edad;
        NumPatas = numPatas;
        Desplazamiento = desplazamiento;
    }

    public void metodo()
    {
        Console.WriteLine("Ladrar");
        Console.WriteLine("Correr");
    }
}