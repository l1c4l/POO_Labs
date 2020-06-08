using System.Collections.Generic;

namespace POO_Lab05_Consola_Lipa.EjerciciosModificados
{
    class Pelicula
    {
        public string nombre { get; set; }
        public string genero { get; set; }
        public int estreno { get; set; }

        List<Pelicula> lista = new List<Pelicula>();
        public Pelicula() { }
        public Pelicula(string nombre, string genero, int estreno)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.estreno = estreno;
        }
        public string Agregar (Pelicula pelicula)
        {
            lista.Add(pelicula);
            return "Película agregada:" +
                "\n* Nombre: " + pelicula.nombre +
                "\n* Género: " + pelicula.genero +
                "\n* Estreno: " + pelicula.estreno;
        }
        public List<Pelicula> Listar() => lista;
    }
}
