using System;

namespace POO_U1_TrabajoFinal.Ejercicio2
{
    class Cuenta
    {
        double saldo { get; set; }
        double retiro { get; set; }
        double deposito { get; set; }
        double pago { get; set; }

        public string usuario;
        public string password;
        public bool estaTarjetaBloqueada;


        public Cuenta(string usuario, string password)
        {
            this.usuario = usuario;
            this.password = password;

            estaTarjetaBloqueada = false;
            saldo = 0;
            retiro = 0;
            deposito = 0;
            pago = 0;
        }
        public bool IngresarCuenta()
        {
            string usu, pass;

            Console.WriteLine("Ingrese su usuario");
            usu = Console.ReadLine();
            Console.WriteLine("ingrese Contraseña");
            pass = Console.ReadLine();

            return VerificarDatosCuenta(usu, pass);
        }
        bool VerificarDatosCuenta(string usu, string pass) => usuario == usu && password == pass;
        public void CambiarPassword()
        {
            string nuevaPassword;
            string comprobacionPassword;

            do
            {
                Console.WriteLine("\nIngrese su nueva contraseña: ");
                nuevaPassword = Console.ReadLine();
                Console.WriteLine("\nIngrese su nueva contraseña otra vez: ");
                comprobacionPassword = Console.ReadLine();

                if (!nuevaPassword.Equals(comprobacionPassword))
                    Console.WriteLine("\nLas contraseñas ingresadas no coinciden");

            } while (comprobacionPassword != nuevaPassword);

            password = nuevaPassword;
            Console.WriteLine("\nTu contraseña se cambio satisfactoriamente");
        }
        public void Depositar(double monto)
        {
            deposito = monto;

            if (deposito >= 0)
            {
                saldo = saldo + deposito;
                Console.WriteLine("Deposito Realizado Satisfactoriamente...");
            }
            else
            {
                Console.WriteLine("El monto a depositar no debe ser menor a 0");
            }
        }
        public void Retirar(double monto)
        {
            retiro = monto;
            if (saldo > retiro)
            {
                saldo = saldo - retiro;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente en tus cuentas");
            }
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("Saldo {0}:", saldo);
        }
        public void PagarServicio(double monto)
        {
            pago = monto;

            if (saldo > pago)
            {
                saldo = saldo - pago;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente no puede pagar sus Servicios");
            }
        }
        public void BloquearTarjeta()
        {
            estaTarjetaBloqueada = true;
        }

        internal void cerrarSesion()
        {
            ;
        }
    }
}
