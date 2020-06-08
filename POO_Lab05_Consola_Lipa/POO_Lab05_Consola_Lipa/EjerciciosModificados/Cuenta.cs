using System;

namespace POO_Lab05_Consola_Lipa.EjerciciosModificados
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
        public double Depositar(double monto)
        {
            deposito = monto;
            saldo += deposito;
            Console.WriteLine("Depósito realizado satisfactoriamente");

            return saldo;
        }
        public double Retirar(double monto)
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
            return saldo;
        }
        public double ConsultarSaldo()
        {
            return saldo;
        }
    }
}
