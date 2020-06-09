using System;

namespace POO_U1_TrabajoFinal.Ejercicio5
{
    class Operacion
    {
        static int incrementable = 0;

        public int id;
        public double numero1;
        public double numero2;
        public string tipo;
        public double resultado;
        public DateTime fechahora;

        public Operacion(double numero1, double numero2, string tipo)
        {
            id = incrementable++;
            this.numero1 = numero1;
            this.numero2 = numero2;
            fechahora = DateTime.Now;

            switch (tipo)
            {
                case "suma": case "+":
                    this.tipo = "suma";
                    resultado = numero1 + numero2;
                    break;
                case "resta": case "-":
                    this.tipo = "resta";
                    resultado = numero1 - numero2;
                    break;
                case "multiplicación": case "*":
                    this.tipo = "multiplicación";
                    resultado = numero1 * numero2;
                    break;
                case "división": case "/":
                    this.tipo = "división";
                    resultado = numero1 / numero2;
                    break;
                default: break;
            }
        }
    }
}
