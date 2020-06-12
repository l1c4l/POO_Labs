using System;

namespace POO_U1_TrabajoFinal.Ejercicio3
{
    class ProgramaTriangulo
    {
        public static void Main()
        {
            Triangulo triangulo = new Triangulo();
            int op;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("           PROGRAMA TRIANGULO                 ");
                Console.WriteLine("==============================================");
                Console.WriteLine();

                triangulo.IngresarDatos();
                
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("                 Tu diseño                    ");
                Console.WriteLine("==============================================");
                Console.WriteLine();

                triangulo.Dibujar();

                Console.WriteLine("=====================================================");
                Console.WriteLine();
                Console.WriteLine("Deseas realizar una nueva consulta? SI [1] , NO [2] ");
                Console.WriteLine();
                op = Convert.ToInt16(Console.ReadLine());

            } while (op == 1);

        }
    }
}
