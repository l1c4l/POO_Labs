using System;
using System.Collections.Generic;

namespace POO_U1_TrabajoFinal.Ejercicio6
{
    class ClasificadorNumeros
    {
        static List<Numero> numeros;

        int numeroLimite;

        int cantidadPares;
        int cantidadImpares;
        double promedioCuadradosPares;
        double promedioCuadradosImpares;
        int sumaCuadrados;
        int sumaCubos;

        public ClasificadorNumeros()
        {
            numeros = new List<Numero>();
            cantidadPares = 0;
            cantidadImpares = 0;
            promedioCuadradosPares = 0;
            promedioCuadradosImpares = 0;
            sumaCuadrados = 0;
            sumaCubos = 0;
        }
        public void GenerarNumeros()
        {
            for (int i = 1; i <= numeroLimite; i++)
                numeros.Add(new Numero(i));
        }
        public void DeterminarParImpar()
        {
            foreach (Numero numero in numeros)
                numero.esPar = numero.valor % 2 == 0;
        }
        public void CalcularCuadradosCubos()
        {
            foreach (Numero numero in numeros)
            {
                numero.valorCuadrado = Convert.ToInt32(Math.Pow(numero.valor, 2));
                numero.valorCubo = Convert.ToInt32(Math.Pow(numero.valor, 3));
            }
        }
        public void IngresarDato()
        {
            Console.Write("\n## Ingrese un número: ");
            numeroLimite = int.Parse(Console.ReadLine());
        }
        public void VisualizarTabla()
        {
            Console.WriteLine("╔════════╦═════╦═══════╦══════════╦══════════╗");
            Console.WriteLine("║ Número ║ Par ║ Impar ║ Cuadrado ║   Cubo   ║");
            Console.WriteLine("╠════════╬═════╬═══════╬══════════╬══════════╣");

            foreach (Numero numero in numeros)
            {
                Console.WriteLine("║ {0,6} ║ {1} ║ {2,8} ║ {3,8} ║",
                    numero.valor, numero.esPar ? " x  ║      " : "    ║   x  ", numero.valorCuadrado, numero.valorCubo);
            }
            Console.WriteLine("╚════════╩═════╩═══════╩══════════╩══════════╝");

        }
        public void CalcularTotalesPromedios()
        {
            foreach (Numero numero in numeros)
            {
                if (numero.esPar)
                {
                    cantidadPares++;
                    promedioCuadradosPares += numero.valorCuadrado;
                }
                else
                {
                    cantidadImpares++;
                    promedioCuadradosImpares += numero.valorCuadrado;
                }
                sumaCuadrados += numero.valorCuadrado;
                sumaCubos += numero.valorCubo;
            }
            promedioCuadradosPares /= cantidadPares;
            promedioCuadradosImpares /= cantidadImpares;
        }
        public void VisualizarTotalesPromedios()
        {
            Console.WriteLine("## Cantidad de números pares: {0}", cantidadPares);
            Console.WriteLine("## Cantidad de números impares: {0}\n", cantidadImpares);
            Console.WriteLine("## Promedio total de cuadrados pares: {0:g2}", promedioCuadradosPares);
            Console.WriteLine("## Promedio total de cuadrados impares: {0:g2}\n", promedioCuadradosImpares);
            Console.WriteLine("## Suma total de cuadrados: {0}", sumaCuadrados);
            Console.WriteLine("## Suma total de cubos: {0}\n", sumaCubos);
        }
    }
}
