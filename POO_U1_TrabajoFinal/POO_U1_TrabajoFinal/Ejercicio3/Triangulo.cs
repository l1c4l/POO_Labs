using System;

namespace POO_U1_TrabajoFinal.Ejercicio3
{
    class Triangulo
    {
        int filas;
        string simbolo;
        public string alineacion;
        public void IngresarDatos()
        {
            Console.WriteLine("ingrese cantidad de filas de la piramide");
            filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingree el simbolo a usar :");
            simbolo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("iNGRESA ALINEACION: \n\r Izquierda = [1] \n\r Derecha   = [2] \n\r Centrado  = [3]");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "1": alineacion = "izquierda"; break;
                case "2": alineacion = "derecha"; break;
                case "3": alineacion = "centrado"; break;
                default: Console.WriteLine("No es una opción válida"); break;
            }
        }
        public void Dibujar()
        {
            int factual, aster;
            switch (alineacion)
            {
                case "izquierda":

                    for (factual = 1; factual <= filas; factual++)
                    {
                        for (aster = 0; aster < (factual); aster++)
                        {
                            Console.Write(simbolo);

                        }
                        Console.WriteLine();

                    }

                    break;

                case "derecha":

                    for (factual = 1; factual <= filas; factual++)
                    {
                        for (int espacios = 0; espacios < filas - factual; espacios++)
                        {
                            Console.Write(" ");
                        }

                        for (aster = 0; aster < factual; aster++)
                        {
                            Console.Write(simbolo);

                        }
                        Console.WriteLine();
                    }
                    break;

                case "centrado":

                    // triangualo centrado
                    for (factual = 1; factual <= filas; factual++)
                    {
                        for (int espacios = 0; espacios < filas - factual; espacios++)
                        {
                            Console.Write(" ");
                        }

                        for (aster = 0; aster < factual * 2 - 1; aster++)
                        {
                            Console.Write(simbolo);
                        }

                        Console.WriteLine();
                    }

                    break;

            }
        }
    }
}
