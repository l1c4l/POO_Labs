using System;

namespace POO_Lab06_Consola_Lipa
{
    class Conversion
    {
        public double monto { get; set; }
        public Conversion()
        {
            monto = 0;
        }
        public void IngresarMonto()
        {
            Console.Write("\n\tIngrese el monto: ");
            monto = double.Parse(Console.ReadLine().Trim());
        }
        public void Convertir()
        {
            Console.WriteLine("\n\t## Importe en soles: {0}", Math.Round(monto, 2));
            Console.WriteLine("\n\t* Cambio en dólares: {0}", Math.Round(monto / 3.43, 2));
            Console.WriteLine("\t* Cambio en euros: {0}", Math.Round(monto / 3.88, 2));
            Console.WriteLine("\t* Cambio en pesos chilenos: {0}", Math.Round(monto * 223.65, 2));
            Console.WriteLine("\t* Cambio en pesos bolivianos: {0}", Math.Round(monto * 2.02, 2));
            Console.WriteLine("\t* Cambio en bolívares: {0}", Math.Round(monto * 57_978.12, 2));
            Console.Read();
        }
    }
}
