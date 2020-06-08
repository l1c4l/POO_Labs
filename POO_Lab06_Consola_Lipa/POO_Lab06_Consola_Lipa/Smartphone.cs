using System;

namespace POO_Lab06_Consola_Lipa
{
    class Smartphone
    {
        private string color { get; set; }
        private string marca { get; set; }
        private int bateria { get; set; }
        public Smartphone(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
        }
        public void Llamar()
        {
            if (bateria == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El celular no cuenta con la batería necesaria");
            }
            bateria -= 10;
            if (bateria < 0)
            {
                bateria = 0;
            }
            Console.WriteLine("El estado actual de la batería es: " + bateria);
        }
        public void Recargar()
        {
            bateria = 100;
        }
    }
}
