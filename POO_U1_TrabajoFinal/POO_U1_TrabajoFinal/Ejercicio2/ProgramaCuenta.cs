using System;

namespace POO_U1_TrabajoFinal.Ejercicio2
{
    class ProgramaCuenta
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Ejecutar();
        }
        static void Ejecutar()
        {
            Cuenta cuenta = new Cuenta("dnavarro", "upt");

            int monto;
            char continuar, opcion, salir;
            int op;

            Console.Clear();
            Console.WriteLine(".................................");
            Console.WriteLine("..   LOGIN ACCESO AL SISTEMA   ..");
            Console.WriteLine(".................................");
            do
            {
                Console.Clear();
                if (cuenta.IngresarCuenta())
                {
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Bienvenido al sistema " + cuenta.usuario);
                        Console.WriteLine("--------------------------------------");

                        Console.WriteLine("==========================");
                        Console.WriteLine("=     Cuenta Bancaria    =");
                        Console.WriteLine("==========================");

                        Console.WriteLine("\n\r Consulta de Saldo  [1] \n\r Depositar          [2] \n\r Retiro Dinero      [3] \n\r Pago de Servicios  [4]\n\r Cambio de Password [5] \n\r Bloqueo de Tajeta  [6] \n\r Ingrese otro dato para salir");
                        Console.WriteLine();
                        Console.WriteLine();
                        opcion = Console.ReadKey(true).KeyChar;
                        Console.WriteLine();

                        switch (opcion)
                        {
                            case '1':
                                cuenta.ConsultaSaldo();
                                break;

                            case '2':
                                Console.WriteLine("Ingrese Cantidad a Depositar: ");
                                monto = int.Parse(Console.ReadLine());
                                cuenta.Depositar(monto);
                                break;

                            case '3':
                                Console.WriteLine("Ingrese Cantidad a Retirar: ");
                                monto = int.Parse(Console.ReadLine());
                                cuenta.Retirar(monto);
                                break;

                            case '4':
                                Console.WriteLine("Paga tus Servicios Aqui :         ");
                                Console.WriteLine("=================================");
                                Console.WriteLine(" Agua     [1] \r\n Luz      [2] \r\n Telefono [3] \r\n Internet [4]");
                                Console.WriteLine("=================================");
                                Console.WriteLine("    Ingrese el monto a pagar     ");
                                Console.WriteLine("=================================");
                                Console.WriteLine();

                                monto = int.Parse(Console.ReadLine());
                                cuenta.PagarServicio(monto);
                                break;

                            case '5':
                                cuenta.CambiarPassword();
                                break;

                            case '6':
                                if (cuenta.estaTarjetaBloqueada)
                                {
                                    Console.WriteLine("Actualmente, su tarjeta está bloqueada");
                                }
                                else
                                {
                                    Console.WriteLine("Deseas Bloquear tu Tarjeta ? SI [1]  NO [2]");
                                    op = int.Parse(Console.ReadLine());
                                    if (op == 1)
                                    {
                                        cuenta.BloquearTarjeta();
                                    }
                                    else
                                    {
                                        Console.WriteLine("---------->>>>  Operacion Cancelada <<<<------------");
                                    }
                                }
                                break;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Para continuar escriba (S)\nPara cerrar sesión escriba (N)");
                        continuar = char.Parse(Console.ReadLine());

                    } while (continuar.Equals('S') || continuar.Equals('s'));
                }
                else
                {
                    Console.WriteLine("Usurio y/o Password incorrectos...");
                    Console.ReadKey();
                }
                Console.WriteLine("Desea salir del Login de Cuenta? presione (s)\nPara continuar, presione (n)");
                salir = Console.ReadKey(true).KeyChar;

            } while (salir != 's' && salir != 'S');
        }
    }
}









