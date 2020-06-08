using System;

namespace POO_Lab04_Consola_Lipa
{
    class Ejercicio2
    {
        public class Operacion
        {
            public int Sumar(int a, int b) => a + b;
            public int Sumar(int a, int b, int c) => a + b + c;
            public int Restar(int a, int b) => a - b;
            public int Restar(int a, int b, int c) => a - b - c;
        }
        static void Main(string[] args)
        {
            Operacion operacion = new Operacion();

            Console.WriteLine("## Operaciones básicas ##\n");
            Console.WriteLine($"* 1 + 1 = {operacion.Sumar(1, 1)}");
            Console.WriteLine($"* 1 + 1 + 1 = {operacion.Sumar(1, 1, 1)}");
            Console.WriteLine($"* 2 - 1 = {operacion.Restar(2, 1)}");
            Console.WriteLine($"* 3 - 2 - 1 = {operacion.Restar(3, 2, 1)}");

            Console.Read();
        }
    }
}
