using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lab02_Consola_Lipa
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Abraham", 22, 1.72),
                estudiante2 = new Estudiante();

            Console.WriteLine("## Estudiante 1 ##\n");
            Console.WriteLine("* El nombre es: " + estudiante1.getNombre());
            Console.WriteLine("* La edad es: " + estudiante1.getEdad());
            Console.WriteLine("* La talla es: " + estudiante1.getTalla());

            Console.WriteLine("\n## Estudiante 2 ##\n");
            Console.Write("* Ingrese el nombre: ");
            estudiante2.setNombre(Console.ReadLine());
            Console.Write("* Ingrese la edad: ");
            estudiante2.setEdad(int.Parse(Console.ReadLine()));
            Console.Write("* Ingrese la talla: ");
            estudiante2.setTalla(double.Parse(Console.ReadLine()));

            Console.WriteLine("\n* El nombre es: " + estudiante2.getNombre());
            Console.WriteLine("* La edad es: " + estudiante2.getEdad());
            Console.WriteLine("* La talla es: " + estudiante2.getTalla());

            Console.Read();
        }
    }
}
