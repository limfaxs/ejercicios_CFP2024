using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeStudiante
{
    public class Ingresante
    {
        string nombre;
        string apellido;
        int edad;
        string genero;
        string pais;
        List<string> cursos;

        public Ingresante(string nombre, string apellido, int edad, string genero, string pais, List<string> cursos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Edad { get => edad; }
        public string Genero { get => genero; }
        public string Pais { get => pais; }
       // public List<string> Cursos 
        public string Cursos 
        {

            get
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < cursos.Count; i++)
                {
                    //No producir un salto de linea. Entonces todo lo que venga lo va a concatenar a la misma altura.
                    sb.Append(cursos[i]);
                    //Como se vehia feo queria mientras que no llegue al final, mientras que no sea la ultima
                    //si hay por lo menos mas de una, va ir agregando la separacion.
                    if (i < cursos.Count -1)
                    {          //agrega la separacion
                        sb.Append(" - ");
                    }
                }

                return sb.ToString();
            }  


        }
    }
}
