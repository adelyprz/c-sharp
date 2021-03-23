using System;
public class Gallina: Aves
{
    public string Ponedora { get; set; }

    public Gallina(string ponedora, string color_plumas, string pico, string nombre, int edad)
    {
        Ponedora = ponedora;
        Color_plumas = color_plumas;
        Tipo_pico = pico;
        Nombre = nombre;
        Edad = edad;
    }

    public void metodo()
    {
        Console.WriteLine("Picotear");
        Console.WriteLine("Cacarear");
    }
}