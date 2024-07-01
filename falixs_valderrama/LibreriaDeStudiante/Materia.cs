using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeStudiante
{
    public class Materia
    {
        // Atributos
        private string nombre;
        // private int duracion;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Materia()
        {
            random = new Random();
        }

        // Constructor
        public Materia(string nombre) //, int duracion)
        {
            this.nombre = nombre;
            // this.duracion = duracion;
        }

        private int CalcularNotaFinal()
        {
            int nota = 0;

            if (notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                nota = random.Next(6, 10);
            }

            return nota;
        }

        private double CalcularPromedio()
        {
            return ((double)notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public override string? ToString()
        {
            return $"{nombre}";
        }

        // Proparties
        public string Nombre { get => nombre; }
        //public int Duracion { get => duracion; }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        public double NotaFinal
        {
            get
            {
                return CalcularNotaFinal();
            }
        }

        public double Promedio
        {
            get
            {
                return CalcularNotaFinal();
            }
        }
    }

}
