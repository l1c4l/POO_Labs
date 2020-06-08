using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lab01_Consola_Lipa
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            // Declarando variables
            string nombre = "María",
                apellido = "Gutierrez";
            int edad = 30;
            double talla = 1.65;
            bool sexo = false;

            // Imprimir en pantalla
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellidos: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Estatura: " + talla);
            Console.WriteLine("Sexo: " + sexo);

            Console.Read();
        }
    }
}
