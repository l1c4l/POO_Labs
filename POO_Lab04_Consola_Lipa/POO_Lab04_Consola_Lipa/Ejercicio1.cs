using System;

namespace POO_Lab04_Consola_Lipa
{
    class Ejercicio1
    {
        public class Ventana
        {
            protected int ancho;
            protected int alto;
            protected string color;
            protected string material;
            protected bool estado; // abierto o cerrado

            public Ventana()
            {
                ancho = 300;
                alto = 200;
                color = "Caoba";
                material = "Madera";
                estado = false; // cerrada
            }
            public Ventana(int ancho, int alto, string color, string material, bool estado)
            {
                this.ancho = ancho;
                this.alto = alto;
                this.color = color;
                this.material = material;
                this.estado = estado;
            }
            ~Ventana()
            {
                Console.WriteLine("Se destruyeron los recursos");
                System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");
            }
            public void Abrir() { estado = true; }
            public void Cerrar() { estado = false; }
            public void VisualizarDatos()
            {
                Console.WriteLine($"\t* Ancho: {ancho}");
                Console.WriteLine($"\t* Alto: {alto}");
                Console.WriteLine($"\t* Color: {color}");
                Console.WriteLine($"\t* Material: {material}");
                Console.WriteLine($"\t* Ventana abierta: {estado}");
            }
        }
        static void Main(string[] args)
        {
            Ventana ventana1 = new Ventana();
            Ventana ventana2 = new Ventana(450, 250, "Blanco", "Plástico", true);

            Console.WriteLine("## Cargando datos iniciales ##\n");

            Console.WriteLine("## Datos de la ventana 1 ##\n");
            ventana1.VisualizarDatos();

            Console.WriteLine("\n## Datos de la ventana 2 ##\n");
            ventana2.VisualizarDatos();

            Console.WriteLine("\nAbriendo la ventana 1...");
            ventana1.Abrir();

            Console.WriteLine("\n## Datos de la ventana 1 ##\n");
            ventana1.VisualizarDatos();

            Console.WriteLine("\nCerrando la ventana 2...");
            ventana2.Cerrar();

            Console.WriteLine("\n## Datos de la ventana 2 ##\n");
            ventana2.VisualizarDatos();

            Console.Read();
        }
    }
}
