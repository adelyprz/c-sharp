using System;
public class Pinguino: Aves
{
    public string Habitad { get; set; }
    public Pinguino(string color_plumas, string habitad, string pico)
    {
        Habitad = habitad;
        Color_plumas = color_plumas;
        Tipo_pico = pico;
    }

    public void metodo()
    {
        Console.WriteLine("Nadar");
        Console.WriteLine("Pezcar");
    }
}