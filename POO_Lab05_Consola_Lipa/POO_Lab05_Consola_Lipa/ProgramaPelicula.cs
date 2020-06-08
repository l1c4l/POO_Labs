using System;

namespace POO_Lab05_Consola_Lipa
{
    class ProgramaPelicula
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            Pelicula peliculas = new Pelicula();
            char opcion = ' ';
            int numero = 1;

            Console.WriteLine("=================================");
            Console.WriteLine("           Películas");
            Console.WriteLine("=================================");
            Console.WriteLine();
            do
            {
                Pelicula pelicula = new Pelicula();

                Console.WriteLine("Agregando la película nro. " + numero++);
                Console.Write("## Ingrese el nombre: ");
                pelicula.nombre = Console.ReadLine();
                Console.Write("## Ingrese el genero: ");
                pelicula.genero = Console.ReadLine();
                Console.Write("## Ingrese el año de estreno: ");
                pelicula.estreno = int.Parse(Console.ReadLine());

                peliculas.Agregar(pelicula);
                Console.WriteLine();

                Console.Write("Si desea seguir agregando otra pelicula presione: (S) (s)... ");
                opcion = char.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (opcion.Equals('S') || opcion.Equals('s'));

            Console.WriteLine("=================================");
            Console.WriteLine("      Relación de películas");
            Console.WriteLine("=================================");
            Console.WriteLine();

            numero = 1;

            foreach (Pelicula pelicula in peliculas.Listar())
            {
                Console.WriteLine("Listando la película nro. " + numero++);

                Console.WriteLine("* Pelicula: " + pelicula.nombre);
                Console.WriteLine("* Genero: " + pelicula.genero);
                Console.WriteLine("* Año de estreno: " + pelicula.estreno);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
