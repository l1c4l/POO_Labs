using System;

namespace POO_Lab05_Consola_Lipa.EjerciciosModificados
{
    class ProgramaCuenta
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            Cuenta cuenta = new Cuenta();
            double monto = 0;

            string opcion = "";
            string continuar = "";

            Console.WriteLine("=================================");
            Console.WriteLine("             Cuenta");
            Console.WriteLine("=================================");

            do
            {
                Console.WriteLine();
                Console.Write("Ingrese alternativa:\n(C)onsultar, (D)epositar, (R)etirar... ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                if (opcion.ToLower().Equals("d"))
                {
                    Console.Write("Ingrese el monto a depositar: ");
                    monto = Convert.ToDouble(Console.ReadLine());
                    cuenta.Depositar(monto);

                    Console.WriteLine("Saldo: {0}", cuenta.ConsultarSaldo()); ;
                }
                else if (opcion.ToLower().Equals("r"))
                {
                    Console.Write("Ingrese el monto a retirar: ");
                    monto = double.Parse(Console.ReadLine());
                    cuenta.Retirar(monto);

                    Console.WriteLine("Saldo: {0}", cuenta.ConsultarSaldo()); ;
                }
                else if (opcion.ToLower().Equals("c"))
                {
                    Console.WriteLine("Saldo: {0}", cuenta.ConsultarSaldo()); ;
                }
                else
                {
                    Console.WriteLine("Debe ingresar una alternativa válida...");
                }

                Console.WriteLine();
                Console.Write("Ingrese (s) o (S) para continuar... ");
                continuar = Console.ReadLine();

            } while (continuar.ToLower().Equals("s"));

            Console.Read();
        }
    }
}
