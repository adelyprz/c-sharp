using System;

namespace _5_propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "David";

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Jose";

            Alumno c = new Alumno(3);
            c.PrimerNombre = "Pedro";
            
            Alumno d = new Alumno("Juan", "Jimenez");
        
            Console.WriteLine(a.Id);
            Console.WriteLine(a.Id);
            Console.WriteLine(a.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);

        }
    }
}
