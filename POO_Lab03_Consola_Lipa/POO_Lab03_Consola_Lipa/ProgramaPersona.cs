using System;

namespace POO_Lab03_Consola_Lipa
{
    class ProgramaPersona
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Abraham";
            persona.Apellido = "Lipa";
            persona.Cargo = "Desarrollador Web";
            persona.SueldoMensual = 2000;

            Console.WriteLine($"Su nombre es: {persona.Nombre}");
            Console.WriteLine($"Su apellido es: {persona.Apellido}");
            Console.WriteLine($"Su cargo es: {persona.Cargo}");
            Console.WriteLine($"Su sueldo mensual es: {persona.SueldoMensual}");
            Console.WriteLine($"Su sueldo anual es: {persona.SueldoAnual}");

            Console.Read();
        }
    }
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public decimal SueldoMensual { get; set; }
        public decimal SueldoAnual { get => SueldoMensual * 12; }
    }
}
