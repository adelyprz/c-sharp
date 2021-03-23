using System;
using System.Collections.Generic;

public class DatosAnimales
{
    //Mamiferos
    public List<Perro> ListaPerro { get; set; }
    public List<Gato> ListaGato { get; set; }
    public List<Delfin> ListaDelfin { get; set; }
    public List<Elefante> ListaElefante { get; set; }
    
    //Aves
    public List<Gallina> ListaGallina { get; set; }
    public List<Aguila> ListaAguila { get; set; }
    public List<Pinguino> ListaPinguino { get; set; }
    

    //Peces
    public List<PezGlobo> ListaPezGlobo { get; set; }
    public List<Tiburon> ListaTiburon { get; set; }
    

    public DatosAnimales()
    {
        //Perros
        ListaPerro = new List<Perro>();
        cargarPerros();

        //Gatos
        ListaGato = new List<Gato>();
        cargarGatos();

        //Elefantes
        ListaElefante = new List<Elefante>();
        cargarElefantes();

        //Delfines
        ListaGallina = new List<Gallina>();
        cargarGallinas();

        //Gallina
        ListaPerro = new List<Perro>();
        cargarPerros();

        //Aguila
        ListaAguila = new List<Aguila>();
        cargarAguilas();
        
        //Pinguino
        ListaPinguino = new List<Pinguino>();
        cargarPinguinos();
        
        //Pez globo
        ListaPezGlobo = new List<PezGlobo>();
        cargarPezGlobo();

        //Tiburoncin
        ListaTiburon = new List<Tiburon>();
        cargarTiburon();
    }

    private void cargarPerros()
    {
        Perro perro1 = new Perro ("Pastor Aleman", "Chispa", 6, 4, "Terrestre");
        ListaPerro.Add(perro1);

        Perro perro2 = new Perro ("Boxer", "Canelo", 3, 4, "Terrestre");
        ListaPerro.Add(perro2);
    }

    private void cargarGatos()
    {
        Gato gato1 = new Gato ("Egipcio", "Bills", 4, 4, "Terrestre");
        ListaGato.Add(gato1);
        
        Gato gato2 = new Gato ("Siames", "Nescafe", 2, 4, "Terrestre");
        ListaGato.Add(gato2);
    }

    private void cargarElefantes()
    {   
        Elefante elef1 = new Elefante("Larga con colmillos", "Paquidermo", "Francisco", 8, 4, "Terrestre");
        ListaElefante.Add(elef1);
        
        Elefante elef2 = new Elefante("Larga sin colmillos", "Paquidermo", "Zizou", 5, 4, "Terrestre");
        ListaElefante.Add(elef2);
    }

    private void cargarDelfines()
    {
        Delfin delfin1 = new Delfin("2 laterales, 1 dorsal y 2 traseras", "Allen", 7, "Acuatico");
        ListaDelfin.Add(delfin1);
        
    }

    private void cargarGallinas()
    {
        Gallina gallina1 = new Gallina("Ponedora", "Negro y cafe", "Corto", "Margarita", 2);
        ListaGallina.Add(gallina1);
    }

    private void cargarAguilas()
    {
        Aguila aguila1 = new Aguila("America", "Cafe y blanco", "Corto", "Pepillo", 1);
        ListaAguila.Add(aguila1);
    }

    private void cargarPinguinos()
    {
        Pinguino ping1 = new Pinguino("Blanco y gris", "Antartida","Alargado");
        ListaPinguino.Add(ping1);
        
        Pinguino ping2 = new Pinguino("Blanco y Negro", "Antartida","Alargado");
        ListaPinguino.Add(ping2);
    }

    private void cargarPezGlobo()
    {
        PezGlobo pez1 = new PezGlobo("Oceano Indico", "Mrs. Puff");
        ListaPezGlobo.Add(pez1);
        
        PezGlobo pez2 = new PezGlobo("Oceano Pacifico", "Mr. Puff");
        ListaPezGlobo.Add(pez2);
    }

    private void cargarTiburon()
    {
        Tiburon tibu1 = new Tiburon("Carnivoro", "Mar Caribe", "Tiburcio");
        ListaTiburon.Add(tibu1);
        
        Tiburon tibu2 = new Tiburon("Vegano", "Mar Caribe", "Juan");
        ListaTiburon.Add(tibu2);
    }

    public void ListarPerros()
    {
        Console.Clear();
        Console.WriteLine("Lista de Perros");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var perro in ListaPerro)
        {
            Console.WriteLine("Raza: " + perro.Raza);
            Console.WriteLine("Nombre: " + perro.Nombre);
            Console.WriteLine("Edad: " + perro.Edad);
            Console.WriteLine("Numero de patas: " + perro.NumPatas);
            Console.WriteLine("Desplazamiento: " + perro.Desplazamiento);
            Console.WriteLine("METODOS");
            perro.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

    public void ListarGatos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Gatos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var gato in ListaGato)
        {
            Console.WriteLine("Raza: " + gato.Raza);
            Console.WriteLine("Nombre: " + gato.Nombre);
            Console.WriteLine("Edad: " + gato.Edad);
            Console.WriteLine("Numero de patas: " + gato.NumPatas);
            Console.WriteLine("Desplazamiento: " + gato.Desplazamiento);
            Console.WriteLine("METODOS");
            gato.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

    public void ListarElefantes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Elefantes");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var elefante in ListaElefante)
        {
            Console.WriteLine("Trompa: " + elefante.Trompa);
            Console.WriteLine("Orden: " + elefante.Orden);
            Console.WriteLine("Nombre: " + elefante.Nombre);
            Console.WriteLine("Edad: " + elefante.Edad);
            Console.WriteLine("Numero de patas: " + elefante.NumPatas);
            Console.WriteLine("Desplazamiento: " + elefante.Desplazamiento);
            Console.WriteLine("METODOS");
            elefante.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }
    public void ListarDelfines()
    {
        Console.Clear();
        Console.WriteLine("Lista de Delfines");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var delfin in ListaDelfin)
        {
            Console.WriteLine("Aletas: " + delfin.Aletas);
            Console.WriteLine("Nombre: " + delfin.Nombre);
            Console.WriteLine("Edad: " + delfin.Edad);
            Console.WriteLine("Desplazamiento: " + delfin.Desplazamiento);
            Console.WriteLine("METODOS");
            delfin.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }
    public void ListarGallinas()
    {
        Console.Clear();
        Console.WriteLine("Lista de Gallinas");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var gallina in ListaGallina)
        {
            Console.WriteLine("Tipo de gallina: " + gallina.Ponedora);
            Console.WriteLine("Longitud de pico: " + gallina.Tipo_pico);
            Console.WriteLine("Color de plumas: " + gallina.Color_plumas);
            Console.WriteLine("Nombre: " + gallina.Nombre);
            Console.WriteLine("Edad: " + gallina.Edad);
            Console.WriteLine("METODOS:");
            gallina.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

    public void ListarAguilas()
    {
        Console.Clear();
        Console.WriteLine("Lista de Aguilas");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var aguila in ListaAguila)
        {
            Console.WriteLine("Region: " + aguila.Region);
            Console.WriteLine("Color de plumas: " + aguila.Color_plumas);
            Console.WriteLine("Longitud de pico: " + aguila.Tipo_pico);
            Console.WriteLine("Nombre: " + aguila.Nombre);
            Console.WriteLine("Edad: " + aguila.Edad);
            Console.WriteLine("METODOS:");
            aguila.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

    public void ListarPinguinos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Pinguinos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var pinguino in ListaPinguino)
        {
            Console.WriteLine("Habitad: " + pinguino.Habitad);
            Console.WriteLine("Color de plumas: " + pinguino.Color_plumas);
            Console.WriteLine("Longitud de pico: " + pinguino.Tipo_pico);
            Console.WriteLine("Nombre: " + pinguino.Nombre);
            Console.WriteLine("Edad: " + pinguino.Edad);
            Console.WriteLine("METODOS:");
            pinguino.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }
    public void ListarPezGlobo()
    {
        Console.Clear();
        Console.WriteLine("Lista de Peces Globo");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var pez in ListaPezGlobo)
        {
            Console.WriteLine("Habitad: " + pez.Habitad);
            Console.WriteLine("Nombre: " + pez.Nombre);
            Console.WriteLine("METODOS");
            pez.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }
    public void ListarTiburoncines()
    {
        Console.Clear();
        Console.WriteLine("Lista de Tiburones");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var tiburon in ListaTiburon)
        {
            Console.WriteLine("Habitad: " + tiburon.Habitad);
            Console.WriteLine("Tipo de Alimentacion: " + tiburon.Alimentacion);
            Console.WriteLine("Nombre: " + tiburon.Nombre);
            Console.WriteLine("METODOS");
            tiburon.metodo();
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

}