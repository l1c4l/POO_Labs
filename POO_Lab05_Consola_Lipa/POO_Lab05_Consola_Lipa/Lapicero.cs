using System;

namespace POO_Lab05_Consola_Lipa
{
    class Lapicero
    {
        public int tinta { get; set; }
        public int gasto { get; set; }
        public int nivelMinimo { get; set; }
        public int nivelMaximo { get; set; }
        public Lapicero()
        {
            nivelMinimo = 0;
            nivelMaximo = 100;
        }
        public void Escribir(int cantidad)
        {
            if (tinta - cantidad >= nivelMinimo)
            {
                tinta -= cantidad;
                gasto += cantidad;
            }
            else if (tinta - cantidad < nivelMinimo)
            {
                Console.WriteLine("Se agotó la tinta del lapicero");
                tinta = nivelMinimo;
            }
        }
        public void Recargar(int cantidad)
        {
            if (tinta + cantidad <= nivelMaximo)
            {
                tinta += cantidad;
            }
            else if (tinta + cantidad > nivelMaximo)
            {
                Console.WriteLine("Se superó el nivel máximo permitido");
                tinta = nivelMaximo;
            }
        }
        public void ConsultarEstado()
        {
            Console.WriteLine("Nivel de tinta: {0}", tinta);
        }
    }
}
