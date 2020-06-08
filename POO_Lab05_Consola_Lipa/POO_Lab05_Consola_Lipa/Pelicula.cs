using System.Collections.Generic;

namespace POO_Lab05_Consola_Lipa
{
    class Pelicula
    {
        public string nombre { get; set; }
        public string genero { get; set; }
        public int estreno { get; set; }

        List<Pelicula> lista = new List<Pelicula>();
        public Pelicula()
        {

        }
        public Pelicula(string nombre, string genero, int estreno)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.estreno = estreno;
        }
        public void Agregar (Pelicula pelicula)
        {
            lista.Add(pelicula);
        }
        public List<Pelicula> Listar()
        {
            return lista;
        }
    }
}
