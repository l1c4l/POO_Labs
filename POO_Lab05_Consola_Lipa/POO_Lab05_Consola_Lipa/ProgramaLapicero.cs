using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lab05_Consola_Lipa
{
    class ProgramaLapicero
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            Lapicero lapicero = new Lapicero();
            int cantidad = 0;

            string opcion = "";
            string continuar = "";

            Console.WriteLine("=================================");
            Console.WriteLine("   Lapicero de tinta líquida");
            Console.WriteLine("=================================");
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.Write("Ingrese alternativa (C)onsultar, (E)scribir, (R)ecargar: ");
                opcion = Console.ReadLine();

                if (opcion.ToLower().Equals("r"))
                {
                    Console.Write("Ingrese la cantidad a recargar: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    lapicero.Recargar(cantidad);

                    Console.WriteLine("Nivel de tinta: {0}", lapicero.tinta); ;
                }
                else if (opcion.ToLower().Equals("e"))
                {
                    Console.Write("Ingrese la cantidad a escribir: ");
                    cantidad = int.Parse(Console.ReadLine());
                    lapicero.Escribir(cantidad);

                    lapicero.ConsultarEstado();
                }
                else if (opcion.ToLower().Equals("c"))
                {
                    lapicero.ConsultarEstado();
                }
                else
                {
                    Console.WriteLine("Debe ingresar una alternativa válida...");
                }

                Console.Write("Ingrese (s) o (S) para continuar... ");
                continuar = Console.ReadLine();

            } while (continuar.ToLower().Equals("s"));

            Console.Read();
        }
    }
}
