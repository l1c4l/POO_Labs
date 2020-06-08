using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lab02_Consola_Lipa
{
    class Estudiante
    {
        String nombre;
        int edad;
        double talla;

        public Estudiante() { }
        public Estudiante(String nombre, int edad, double talla)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.talla = talla;
        }
        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public double getTalla()
        {
            return talla;
        }
        public void setTalla(double talla)
        {
            this.talla = talla;
        }
        
    }
}
