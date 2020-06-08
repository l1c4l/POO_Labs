using System;

namespace POO_Lab06_Consola_Lipa
{
    class ProgramaConversion
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            Conversion conversion = new Conversion();
            char opcion;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            do
            {
                Console.WriteLine("\n\t====================");
                Console.WriteLine("\t   Menú principal");
                Console.WriteLine("\t====================");
                Console.WriteLine("\n\t1.- Ingresar monto");
                Console.WriteLine("\t2.- Realizar conversión");
                Console.WriteLine("\t[0] Salir");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\tIngrese opción: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                } while (opcion < '0' || opcion > 'N');

                Console.Write(opcion + "\n");

                switch (opcion)
                {
                    case '1':
                        conversion.IngresarMonto();
                        Console.Clear();
                        break;
                    case '2':
                        conversion.Convertir();
                        Console.Clear();
                        break;
                    case '0': break;
                    default:
                        Console.WriteLine("\tDebe elegir una opción válida...");
                        break;
                }

            } while (opcion != '0');

            Console.Read();
        }
    }
}
