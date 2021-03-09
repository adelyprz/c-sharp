using System;
using System.Collections.Generic;

namespace listados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Ramon");
            nombres.Add("Luis");
            nombres.Add("Pedro");
            
            foreach (var nombre in nombres)
            {
                Console.WriteLine (nombre);
            }

            List<int> numeros = new List<int>();
            numeros.Add(7); 
            numeros.Add(21); 
            numeros.Add(19); 

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno (1, "Pedro");
            Alumno b = new Alumno (1, "Rodrigo");
            Alumno c = new Alumno (1, "Maria");

            alumnos.Add(a);
            alumnos.Add(b);
            alumnos.Add(c);

            foreach (var alumno in alumnos)
            {
                Console.WriteLine (alumno.Nombre);
            }
        }
    }
}
