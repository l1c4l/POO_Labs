using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lab01_Consola_Lipa
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            // Declarando variables
            string nombre, apellido;
            int edad;
            double talla;
            bool sexo;

            // Ingresar por teclado
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la estatura: ");
            talla = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el sexo: ");
            sexo = bool.Parse(Console.ReadLine());

            // Imprimir en pantalla
            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("Apellidos: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Estatura: " + talla);
            Console.WriteLine("Sexo: " + sexo);

            Console.Read();
        }
    }
}
