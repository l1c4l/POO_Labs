using System;

namespace POO_U1_TrabajoFinal.Ejercicio6
{
    class ProgramaClasificadorNumeros
    {
        public static void Main()
        {
            char opcion;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                ClasificadorNumeros clasificadorNumeros = new ClasificadorNumeros();

                Console.Clear();
                
                Console.WriteLine("=======================");
                Console.WriteLine("     Ejercicio 6");
                Console.WriteLine("=======================\n");

                clasificadorNumeros.IngresarDato();
                clasificadorNumeros.GenerarNumeros();
                clasificadorNumeros.DeterminarParImpar();
                clasificadorNumeros.CalcularCuadradosCubos();
                clasificadorNumeros.CalcularTotalesPromedios();

                clasificadorNumeros.VisualizarTabla();
                clasificadorNumeros.VisualizarTotalesPromedios();

                Console.Write("\nPresione (r) para reiniciar... ");

                opcion = Console.ReadKey(true).KeyChar;

            } while (opcion == 'r');
        }
    }
}
