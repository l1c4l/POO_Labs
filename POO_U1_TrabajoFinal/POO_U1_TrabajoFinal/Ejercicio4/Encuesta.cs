using System;

namespace POO_U1_TrabajoFinal.Ejercicio4
{
    class Encuesta
    {
        public string[] opciones;
        public string[] preguntas;
        public string[] titulos;

        public int[,] resultados;

        public int cantidadEncuestados;
        public Encuesta()
        {
            opciones = new string[6] { "C#", "Java", "Python", "Javascript", "Rust", "Kotlin" };
            preguntas = new string[3] { "¿Cual es el que más usas?", "¿Cual quisieras aprender este año?", "¿Cual te agrada menos?" };
            titulos = new string[3] { "Más usados", "Más interesantes", "Menos gustados" };
            resultados = new int[3, 6];
            cantidadEncuestados = 0;
        }
        public void Votar()
        {
            Console.WriteLine("\n## Complete la encuesta ##");
            Console.WriteLine("La encuesta consiste en 3 preguntas con 6 alternativas cada una");
            foreach (string pregunta in preguntas)
            {
                int opcionSeleccionada;
                int indicePregunta = Array.IndexOf(preguntas, pregunta);

                Console.WriteLine("\n{0}. {1}\n", indicePregunta + 1, pregunta);
                Console.WriteLine("Opciones:");
                foreach (string opcion in opciones)
                {
                    Console.WriteLine("[{0}] {1}", Array.IndexOf(opciones, opcion) + 1, opcion);
                }
                Console.Write("\nIngrese una opción: ");

                opcionSeleccionada = int.Parse(Console.ReadLine());
                resultados[indicePregunta, opcionSeleccionada - 1]++;
            }
            cantidadEncuestados++;
        }
        public void VerResultados()
        {
            Console.WriteLine("## Lenguajes de programación ##");
            foreach (string titulo in titulos)
            {
                Console.WriteLine("\n{0}:\n", titulo);
                Console.WriteLine("╔════════╦════════════╦════════════════════════╦════════════╗");
                Console.WriteLine("║ Número ║   Opción   ║          Barra         ║ Porcentaje ║");
                Console.WriteLine("╠════════╬════════════╬════════════════════════╬════════════╣");
                foreach (string opcion in opciones)
                {
                    int indicePregunta = Array.IndexOf(titulos, titulo);
                    int indiceOpcion = Array.IndexOf(opciones, opcion);
                    int resultado = resultados[indicePregunta, indiceOpcion];

                    double porcentaje = (double)(resultado) / cantidadEncuestados * 100.0;
                    int cantidadBloques = (int)(porcentaje / 5.0);
                    Console.WriteLine("║ {0,6} ║ {1,10} ║ [{2,20}] ║ {3,9:N}% ║", indiceOpcion + 1, opcion, new String('=', cantidadBloques).PadRight(20), porcentaje);
                }
                Console.WriteLine("╚════════╩════════════╩════════════════════════╩════════════╝");
            }
        }
    }
}
