using System;

namespace POO_U1_TrabajoFinal.Ejercicio5
{
    class ProgramaOperador
    {
        public static void Main()
        {
            Operador operador = new Operador();
            char opcion = '4';
            bool continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("     Ejercicio 5");
                Console.WriteLine("=======================\n");

                if (opcion == '4') { operador = new Operador(); }

                Console.WriteLine("## Opciones:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Reiniciar");
                Console.WriteLine("[Enter] Salir");

                opcion = Console.ReadKey(true).KeyChar;
                switch (opcion)
                {
                    case '1': operador.Agregar(); break;
                    case '2': operador.Listar(); break;
                    case '3': operador.Buscar(); break;
                    case '4': Console.WriteLine("\nSe han reiniciado los datos de la encuesta."); break;
                    default: break;
                }

                continuar = opcion == '1' || opcion == '2' || opcion == '3' || opcion == '4';

                Console.WriteLine("\nPresione [Enter] para continuar...");
                Console.ReadKey();

            } while (continuar);
        }
    }
}
