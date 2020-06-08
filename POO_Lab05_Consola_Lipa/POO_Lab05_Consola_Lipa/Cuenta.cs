using System;

namespace POO_Lab05_Consola_Lipa
{
    class Cuenta
    {
        public double saldo { get; set; }
        public double deposito { get; set; }
        public double retiro { get; set; }
        public Cuenta()
        {
            saldo = 0;
            deposito = 0;
            retiro = 0;
        }
        public void Depositar(double monto)
        {
            deposito = monto;
            saldo += deposito;
            Console.WriteLine("Depósito realizado satisfactoriamente");
        }
        public void Retirar(double monto)
        {
            retiro = monto;
            if (saldo >= retiro)
            {
                saldo -= retiro;
            }
            else
            {
                Console.WriteLine("No tienes suficiente saldo");
            }
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo: {0}", saldo);
        }
    }
}
