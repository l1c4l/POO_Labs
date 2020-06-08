using System;

namespace POO_Lab05_Consola_Lipa
{
    class Operaciones
    {
        public double a { get; set; }
        public double b { get; set; }

        public double resultado;
        public Operaciones()
        {
            a = 0;
            b = 0;
        }
        public double Sumar(double a, double b)
        {
            resultado = a + b;
            return resultado;
        }
        public double Restar(double a, double b)
        {
            resultado = a - b;
            return resultado;
        }
        public double Multiplicar(double a, double b)
        {
            resultado = a * b;
            return resultado;
        }
        public double Dividir(double a, double b)
        {
            if (b != 0)
            {
                resultado = a / b;
                return resultado;
            }
            else
            {
                Console.WriteLine("** El valor de b debe ser distinto de 0 **");
            }
            return 0;
        }
        public void Limpiar()
        {
            a = 0;
            b = 0;
        }
        public void IngresarDatos()
        {
            Console.Write("## Ingrese a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("## Ingrese b: ");
            b = double.Parse(Console.ReadLine());
        }
        public void VisualizarDatos()
        {
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║ Visualización de datos ║");
            Console.WriteLine("╠════════════════════════╣");
            Console.WriteLine("║ a: {0,19:g17} ║", a);
            Console.WriteLine("║ b: {0,19:g17} ║", b);
            Console.WriteLine("╚════════════════════════╝");
        }
        public void VisualizarResultado()
        {
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║ Resultado de operación ║");
            Console.WriteLine("╠════════════════════════╣");
            Console.WriteLine("║ resultado: {0,11:g6} ║", resultado);
            Console.WriteLine("╚════════════════════════╝");
        }
        ~Operaciones()
        {
            System.Diagnostics.Trace.WriteLine("Destruyendo lo inicializado...");
        }
    }
}
