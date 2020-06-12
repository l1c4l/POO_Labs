using System;
using System.Text.RegularExpressions;

namespace POO_U1_TrabajoFinal.Ejercicio4
{
    class ProgramaEncuesta
    {
        public static void Main()
        {
            Encuesta encuesta = new Encuesta();
            char opcion = '3';
            bool continuar;

            Console.BackgroundColor = ConsoleColor.DarkYellow;

            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("     Ejercicio 4");
                Console.WriteLine("=======================\n");

                if (opcion == '3') encuesta = new Encuesta();

                Console.WriteLine("## Opciones:");
                Console.WriteLine("1. Votar");
                Console.WriteLine("2. Ver resultados");
                Console.WriteLine("3. Reiniciar");
                Console.WriteLine("4. Regresar");
                Console.WriteLine("0. Salir");

                Regex regex = new Regex(@"[0-4]"); // patrón: del 0 al 4
                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                } while (!regex.Match(opcion.ToString()).Success);

                switch (opcion)
                {
                    case '1': encuesta.Votar(); break;
                    case '2': encuesta.VerResultados(); break;
                    case '3': Console.WriteLine("\nSe han reiniciado los datos de la encuesta."); break;
                    case '4': Program.Main(); break;
                }

                continuar = opcion == '1' || opcion == '2' || opcion == '3';

                Console.WriteLine("\nPresione [Enter] para continuar...");
                Console.ReadKey(true);

            } while (continuar);
        }
    }
}
