using System;

namespace POO_U1_TrabajoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número del ejercicio (1-6): ");
            
            switch (Console.ReadLine())
            {
                case "1": Ejercicio3.ProgramaFigura.Main(); break;
                case "2": Ejercicio3.ProgramaFigura.Main(); break;
                case "3": Ejercicio3.ProgramaFigura.Main(); break;
                case "4": Ejercicio4.ProgramaEncuesta.Main(); break;
                case "5": Ejercicio5.ProgramaOperador.Main(); break;
                case "6": Ejercicio6.ProgramaClasificadorNumeros.Main(); break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
