using System;

namespace POO_Lab03_Consola_Lipa
{
    class ProgramaEmpleado
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Enrique");

            Console.WriteLine("## Empleado ##\n");
            Console.WriteLine("* Nombre asignado en constructor");

            Console.WriteLine($"\tSu nombre es: {empleado.Nombre}");
            
            empleado.Sueldo = 1200;
            empleado.Sueldo += 800;

            Console.WriteLine("* Sueldo asignado 1200 + 800");
            Console.WriteLine($"\tSu sueldo es: {empleado.Sueldo}");

            empleado.Nombre = "Enrique";
            empleado.Sueldo -= 3000;

            Console.WriteLine("* Nombre asignado en Nombre { set }");
            Console.WriteLine($"\tSu nombre es: {empleado.Nombre}");
            Console.WriteLine("* Sueldo evaluado -1000 y asignado 0");
            Console.WriteLine($"\tSu sueldo es: {empleado.Sueldo}");

            Console.Read();
        }
    }
    class Empleado
    {
        private string nombre;
        private double sueldo;
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre {
            get => nombre;
            set { nombre = "Abraham"; }
        }
        public double Sueldo
        {
            get => sueldo;
            set { sueldo = EvaluarSalario(value); }
        }
        private double EvaluarSalario(double salario)
            => salario < 0 ? 0 : salario;
    }
}
