using System;

namespace POO_Lab05_Consola_Lipa
{
    class ProgramaOperaciones
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();

            Console.WriteLine("=================================");
            Console.WriteLine("Valores iniciales del constructor");
            Console.WriteLine("=================================");
            Console.WriteLine();
            operaciones.VisualizarDatos();
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("     Operaciones aritméticas");
            Console.WriteLine("=================================");
            Console.WriteLine();
            operaciones.IngresarDatos();
            Console.WriteLine();
            operaciones.VisualizarDatos();
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("              Suma");
            Console.WriteLine("=================================");
            Console.WriteLine();
            operaciones.Sumar(operaciones.a, operaciones.b);
            operaciones.VisualizarResultado();
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("              Restar");
            Console.WriteLine("=================================");
            Console.WriteLine();
            operaciones.Restar(operaciones.a, operaciones.b);
            operaciones.VisualizarResultado();
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("           Multiplicar");
            Console.WriteLine("=================================");
            Console.WriteLine();
            operaciones.Multiplicar(operaciones.a, operaciones.b);
            operaciones.VisualizarResultado();
            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("             Dividir");
            Console.WriteLine("=================================");
            Console.WriteLine();
            operaciones.Dividir(operaciones.a, operaciones.b);
            operaciones.VisualizarResultado();
            Console.WriteLine();

            Console.Read();
        }
    }
}
