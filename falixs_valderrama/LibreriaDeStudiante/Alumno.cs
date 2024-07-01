using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace LibreriaDeStudiante
{
    public class Alumno
    {
        // Atributos       
        private string legajo;
        private string nombre;
        private string apellido;

        //Marcar como comentario      
        //private int notaPrimerParcial;
        //private int notaSegundoParcial;
        //private static Random random;

        //
        public string Legajo
        {
            set
            {
                this.legajo = value;
            }

            get
            {
                return this.legajo;
            }
            
        }
        //
        // Proparties
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        //marcar como comentario
        //public int NotaPrimerParcial
        //{
        //    get => notaPrimerParcial;

        //    set
        //    {
        //        if (value >= 0 && value <= 10)
        //        {
        //            notaPrimerParcial = value; 
        //        }
        //        else
        //        {
        //            notaPrimerParcial = 0;
        //        }
        //    }
        //}

        //public int NotaSegundoParcial
        //{
        //    get => notaSegundoParcial;

        //    set
        //    {
        //        if (value >= 0 && value <= 10)
        //        {
        //            notaSegundoParcial = value;
        //        }
        //        else
        //        {
        //            notaSegundoParcial = 0;
        //        }
        //    }
        //}

        //
        // Marcar como comentario
        //public double NotaFinal
        //{
        //    get
        //    {
        //        return this.CalcularNotaFinal();
        //    }
        //}
        ////
        //public double promedio
        //{
        //    get
        //    {
        //        return this.calcularPromedio();
        //    }
        //}



        // Constructor estatico

        // Marcar como comentario
        //static Alumno()
        //{
        //    Alumno.random = new Random();
        //}

        //Constructor De Instancia
        public Alumno(string legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;            
        }

        // Seters

        //marcar como comentario
        //public void SetNotaPrimerParcial(int nota)
        //{
        //    this.notaPrimerParcial = nota;
        //}
        //public void SetNotaSegundoParcial(int nota)
        //{
        //    this.notaSegundoParcial = nota;
        //}

        //
        // Marcar como comentario
        //public Alumno()
        //{

        //}

        // Metodos
        // Marcar como comentario
        //private double calcularPromedio()
        //{
        //    return ((double)notaPrimerParcial + notaSegundoParcial) / 2;
        //}

        //public double CalcularNotaFinal()
        //{
        //    double resultado = -1;
        //    if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
        //    {
        //        resultado = Alumno.random.Next(6, 10);
        //    }

        //    return resultado;
        //}

        //
        //public double CalcularNotaFinal()
        //{
        //    double notaFinal = -1;
        //    if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
        //    {
        //        notaFinal = random.Next(6, 11);
        //    }

        //    return notaFinal;
        //}

        // Marcar como comentario
        //public string mostrar()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"Alumno: {this.apellido}, {this.nombre} - Leg: N°{this.legajo}");
        //    sb.AppendLine($"1° Parcial: {this.notaPrimerParcial} - 2° Parcial: {this.notaSegundoParcial}");
        //    sb.AppendLine($"Promedio: {this.calcularPromedio()}");

        //    double notaFinal = this.CalcularNotaFinal();

        //    if (notaFinal != -1)
        //    {
        //        sb.AppendLine($"Nota Final: {notaFinal}");
        //    }
        //    else
        //    {
        //        sb.AppendLine($"\"Alumno Desaprobado\"");
        //    }
        //    return sb.ToString();

        //}

        public static List<Alumno> ListaAlumnos()
        {
            return new List<Alumno>
            {
                    new Alumno("1001", "Cuellar", "Pedro"),
                    new Alumno("1002", "Pugo", "Jeremias"),
                    new Alumno("1003", "Hidalgo", "Carlo"),
                    new Alumno("1004", "Aguilar", "Jorge"),
                    new Alumno("1005", "Puyol", "Jimy"),



            };
        }

        public override string? ToString()
        {
            return $"{apellido}, {nombre}";
        }

        //
        // Metodos
        //public double CalcularNotaFinal()
        //{
        //    int notaFinal = -1;
        //    if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
        //    {
        //        notaFinal = random.Next(6, 11);
        //    }

        //    return notaFinal;
        //}
        //private double calcularPromedio()
        //{
        //    return ((double)notaPrimerParcial + notaSegundoParcial) / 2;
        //}
        //static Estudiante()
        //{
        //    Estudiante.random = new Random();
        //}
        //public Estudiante (string apellido, string legajo, string nombre)
        //{
        //    this.apellido = apellido;
        //    this.legajo = legajo;
        //    this.nombre = nombre;
        //}
        //public string mostrar()
        //{
        //    return $"nombre: {nombre} - apellido: {apellido} - legajo: {legajo} - nota primer parcial: {notaPrimerParcial} - nota segundo parcial: {notaSegundoParcial}";
        //}
        //public void SetNotaPrimerParcial (int nota)
        //{
        //    this.notaPrimerParcial = nota;
        //    notaPrimerParcial = nota;
        //}
        //public void SetNotaSegundoParcial (int nota)
        //{
        //    this.SetNotaSegundoParcial(nota);
        //    notaSegundoParcial = nota;
        //}


    }
    
}
