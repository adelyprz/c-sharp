using System;

namespace Pilares_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosAnimales datos = new DatosAnimales();
            string opcion = " ";
            int subOpcion = 0;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO!!");
                Console.WriteLine("1 - Mamiferos");
                Console.WriteLine("2 - Aves");
                Console.WriteLine("3 - Peces");
                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();

                
                    if(opcion == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("**MAMIFEROS**");
                        Console.WriteLine("1 - Perros");
                        Console.WriteLine("2 - Gatos");
                        Console.WriteLine("3 - Elefantes");
                        Console.WriteLine("4 - Delfines");
                        Console.Write("Ingrese una opcion: ");
                        subOpcion = Int32.Parse(Console.ReadLine());

                        switch(subOpcion)
                        {
                            case 1:
                                datos.ListarPerros();
                                break;
                            
                            case 2:
                                datos.ListarGatos();
                                break;
                            
                            case 3:
                                datos.ListarElefantes();
                                break;
                            
                            case 4:
                                datos.ListarDelfines();
                                break;
                        }
                    }

                    if (opcion == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("**AVES**");
                        Console.WriteLine("1 - Gallinas");
                        Console.WriteLine("2 - Aguilas");
                        Console.WriteLine("3 - Pinguinos");
                        Console.Write("Ingrese una opcion: ");
                        subOpcion = Int32.Parse(Console.ReadLine());

                        switch(subOpcion)
                        {
                            case 1:
                                datos.ListarGallinas();
                                break;
                            
                            case 2:
                                datos.ListarAguilas();
                                break;
                            
                            case 3:
                                datos.ListarPinguinos();
                                break;
                        }
                        
                    }

                    if (opcion == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("**PECES**");
                        Console.WriteLine("1 - Pez Globo");
                        Console.WriteLine("2 - Tiburones");
                        Console.Write("Ingrese una opcion: ");
                        subOpcion = Int32.Parse(Console.ReadLine());

                        switch(subOpcion)
                        {
                            case 1:
                                datos.ListarPezGlobo();
                                break;
                            
                            case 2:
                                datos.ListarTiburoncines();
                                break;
                        }
                    }
                        
                    

                    if(opcion == "0")
                    {
                        break;
                    }
            }
            
            

            
        }
    }
}
