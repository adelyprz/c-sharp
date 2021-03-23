using System;
public class Aguila: Aves
{
    public string Region { get; set; }
    
    public Aguila(string region, string color_plumas, string pico, string nombre, int edad)
    {
        Region = region;
        Color_plumas = color_plumas;
        Tipo_pico = pico;
        Nombre = nombre;
        Edad = edad;
    }

    public void metodo()
    {
        Console.WriteLine("Cazar");
        Console.WriteLine("Volar y elevarse");
    }
}