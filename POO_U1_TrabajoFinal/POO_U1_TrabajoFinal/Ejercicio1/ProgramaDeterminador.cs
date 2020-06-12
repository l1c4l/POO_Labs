using System;

namespace POO_U1_TrabajoFinal.Ejercicio1
{
    class ProgramaDeterminador
    {

        public static void Main()
        {
            Determinador determinador = new Determinador();
            int opcion;

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            do
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("      MAYOR , INTERMEDIO Y MENOR       ");
                Console.WriteLine("=======================================");

                determinador.IngresarDatos();

                if (determinador.ValidarDatos())
                {
                    determinador.DeterminarPosiciones();
                 
                    Console.WriteLine();
                    Console.WriteLine("=======================================");
                    
                    determinador.MostrarResultados();
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor distinto a cero...");
                }

                Console.WriteLine();

                Console.WriteLine("Deseas realizar una nueva consulta? SI [1] , NO [2] ");
                Console.WriteLine();
                opcion = Convert.ToInt16(Console.ReadLine());

            } while (opcion == 1);

            Program.Main();
        }
    }
}
