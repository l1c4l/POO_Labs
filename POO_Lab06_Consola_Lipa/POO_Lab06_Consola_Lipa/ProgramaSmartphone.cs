using System;

namespace POO_Lab06_Consola_Lipa
{
    class ProgramaSmartphone
    {
        static void Main(string[] args)
        {
            Iniciar();
        }
        static void Iniciar()
        {
            Smartphone smartphone = new Smartphone("negro", "Huawei");

            smartphone.Recargar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();
            smartphone.Llamar();

            Console.Read();
        }
    }
}
