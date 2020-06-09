using System;

namespace POO_U1_TrabajoFinal.Ejercicio4
{
    class ProgramaEncuesta
    {
        public static void Main()
        {
            Encuesta encuesta = new Encuesta();
            char opcion = '3';
            bool continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("     Ejercicio 4");
                Console.WriteLine("=======================\n");

                if (opcion == '3') { encuesta = new Encuesta(); }

                Console.WriteLine("## Opciones:");
                Console.WriteLine("1. Votar");
                Console.WriteLine("2. Ver resultados");
                Console.WriteLine("3. Reiniciar");
                Console.WriteLine("[Enter] Salir");

                opcion = Console.ReadKey(true).KeyChar;
                switch (opcion)
                {
                    case '1': encuesta.Votar(); break;
                    case '2': encuesta.VerResultados(); break;
                    case '3': Console.WriteLine("Se han reiniciado los datos de la encuesta."); break;
                    default: break;
                }

                continuar = opcion == '1' || opcion == '2' || opcion == '3';

                Console.WriteLine("\nPresione [Enter] para continuar");
                Console.ReadKey();

            } while (continuar);
        }
    }
}
