using System;

namespace POO_U1_TrabajoFinal.Ejercicio1
{
    class Determinador
    {
        public int n1, n2, n3;
        public int Mayor, inter, menor;
        public Determinador()
        {
            Mayor = 0;
            inter = 0;
            menor = 0;
        }
        public void IngresarDatos()
        {
            Console.WriteLine("Ingrese el 1er valor : ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ingrese el 2do Valor : ");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er valor : ");
            n3 = Convert.ToInt16(Console.ReadLine());
        }

        public void MostrarResultados()
        {
            Console.WriteLine("El numero mayor es :" + Mayor);
            Console.WriteLine("El numero Intermedio es :" + inter);
            Console.WriteLine("El numero menor es: " + menor);
        }

        public bool ValidarDatos()
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
        public void DeterminarPosiciones()
        {
            if (n1 > n2)
            {
                Mayor = n1;
                menor = n2;
            }
            else
            {
                Mayor = n2;
                menor = n1;
            }

            if (Mayor > n3)
            {
                if (menor > n3)
                {
                    inter = menor;
                    menor = n3;
                }
                else
                {
                    inter = n3;
                }
            }
            else
            {
                inter = Mayor;
                Mayor = n3;
            }
        }
    }
}
