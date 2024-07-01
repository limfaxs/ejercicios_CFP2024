using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeStudiante
{
    public class EstadoAcademico
    {
        private Alumno alumno;       
        private string carrera;
        private List<Materia> materias;

        private EstadoAcademico()
        {
            materias = new List<Materia>();
        }

        // Marcar como comentario
        //public EstadoAcademico(Alumno alumno)
        //    :this()
        //{
        //    this.alumno = alumno;
        //}

        public EstadoAcademico(Alumno alumno, string carrera)

            :this()
            //:this(alumno)
        {
            //
            this.alumno = alumno;
            this.Carrera = carrera;
        }

        // Marcar como comentario
        ////public EstadoAcademico(Alumno alumno, string carrera, List<Materia> materias)
        ////    :this(alumno, carrera)
        ////{
        ////    //this.alumno = alumno;
        ////    //this.carrera = carrera;
        ////    this.materias = materias;
        ////}


        // Marcar como comentario
        //private EstadoAcademico()
        //{
        //    this.materias = new List<Materia>();

        //    //
        //    //this.alumno = new Alumno();
        //    this.carrera = string.Empty;
        //    //
        //}
        
        //public EstadoAcademico(Alumno alumno) :this()
        //{
        //    this.alumno = alumno;

        //    //
        //    this.materias = new List<Materia>();
        //    //                      
        //}

        //public EstadoAcademico(Alumno alunno, List<Materia> materias) :this(alunno)
        //{
        //    this.materias = materias;

        //    //
        //    this.alumno = alunno;
        //    this.carrera = string.Empty;
        //    //           
        //}

        //public EstadoAcademico(Alumno alunno, List<Materia> materias, string carrera) : this(alunno, materias)
        //{
        //    this.carrera = carrera;

        //    //
        //    this.alumno = alunno;
        //    this.materias = materias;
        //    //           
        //}

        //
        //public Evaluacion(List<Materia> materias, Alumno alunno) : this(alunno, materias)
        //{

        //}

        public Materia SetMateria
        {
            set
            {
                this.materias.Add(value);
            }
        }

        public List<Materia> Materias
        {
            get
            {
                return this.materias;
            }
        }

        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }

        public string Carrera { get => carrera; set => carrera = value; }
    }

}
