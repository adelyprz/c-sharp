using System;
public class Gato: Mamiferos
{   
    public string Raza { get; set; }
    public Gato(string raza, string nombre, int edad, int numPatas, string desplazamiento)
    {   
        Raza = raza;
        Nombre = nombre;
        Edad = edad;
        NumPatas = numPatas;
        Desplazamiento = desplazamiento;
    }

    public void metodo()
    {
        Console.WriteLine("Maullar");
    }
}