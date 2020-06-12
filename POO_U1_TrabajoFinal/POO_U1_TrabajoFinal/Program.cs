using System;

namespace POO_U1_TrabajoFinal
{
    class Program
    {
        public static void Main()
        {
            int opcion;
            bool continuar;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Clear();
                Console.WriteLine("\t## Trabajo final de POO ##\n");
                Console.WriteLine("\tEjercicios:\n");
                Console.WriteLine("\t1. Números");
                Console.WriteLine("\t2. Cuenta");
                Console.WriteLine("\t3. Triángulo");
                Console.WriteLine("\t4. Encuesta");
                Console.WriteLine("\t5. Operaciones");
                Console.WriteLine("\t6. Números");
                Console.WriteLine("\t[0] Salir");
                Console.Write("\n\t* Ingrese el número del ejercicio (1-6): ");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Ejercicio1.ProgramaDeterminador.Main(); break;
                    case 2: Ejercicio2.ProgramaCuenta.Main(); break;
                    case 3: Ejercicio3.ProgramaTriangulo.Main(); break;
                    case 4: Ejercicio4.ProgramaEncuesta.Main(); break;
                    case 5: Ejercicio5.ProgramaOperador.Main(); break;
                    case 6: Ejercicio6.ProgramaClasificadorNumeros.Main(); break;
                    default: Console.WriteLine("\n\tIngrese un opción válida (entre 1 y 6)"); break;
                }
                continuar = opcion != 0;
            } while (continuar);
        }
    }
}
