using System;
using System.Collections.Generic;
using System.Linq;

namespace POO_U1_TrabajoFinal.Ejercicio5
{
    class Operador
    {
        public List<Operacion> operaciones;
        public Operador()
        {
            operaciones = new List<Operacion>();
        }
        public void Agregar()
        {
            double numero1, numero2;
            string tipo;

            Console.Write("* Ingrese un número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("* Ingrese otro número: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.Write("* Ingrese el tipo de operación (puede ser el símbolo): ");
            tipo = Console.ReadLine();

            operaciones.Add(new Operacion(numero1, numero2, tipo));
        }
        public void Listar()
        {
            Console.WriteLine("╔════╦══════════╦══════════╦════════════════╦═══════════╦═════════════════════╗");
            Console.WriteLine("║ Id ║ Número 1 ║ Número 2 ║      Tipo      ║ Resultado ║     Fecha / Hora    ║");
            Console.WriteLine("╠════╬══════════╬══════════╬════════════════╬═══════════╬═════════════════════╣");

            foreach (Operacion operacion in operaciones)
            {
                Console.WriteLine("║ {0,2} ║ {1,8} ║ {2,8} ║ {3,14} ║ {4,9} ║ {5,19:G} ║",
                    operacion.id, operacion.numero1, operacion.numero2, operacion.tipo, operacion.resultado, operacion.fechahora);
            }
            Console.WriteLine("╚════╩══════════╩══════════╩════════════════╩═══════════╩═════════════════════╝");
        }
        public void Buscar()
        {
            Console.Write("Ingrese el tipo de operación a filtrar: ");
            string tipoOperacion = Console.ReadLine();

            Operador operacionesFiltradas = new Operador();
            operacionesFiltradas.operaciones = operaciones.Where(operacion => operacion.tipo == tipoOperacion).ToList();
            operacionesFiltradas.Listar();
        }
    }
}
