using LibreriaDeStudiante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumnos
{
    public partial class FormEstadoAcademico : Form
    {
        private Alumno alumno;
        private List<Materia> materias;
        private string carrera;

        public FormEstadoAcademico()
        {
            InitializeComponent();
        }

        public FormEstadoAcademico(Alumno alumno, List<Materia> materias, string carrera)
            : this()
        {
            this.alumno = alumno;
            this.materias = materias;
            this.carrera = carrera;

        }

        //private void load(object s, EventArgs e)
        //{
        //    CargarLsb();
        //}

        private void CargarLsb()
        {
            listBox1.Items.Add(alumno);
            listBox1.Items.Add($"Carrera: {carrera}");
            listBox1.Items.Add($"Listado de materias: ");

            foreach (Materia iten in materias)
            {
                listBox1.Items.Add(iten.Nombre);
            }

        }

        private void FormEstadoAcademico_Load(object sender, EventArgs e)
        {
            CargarLsb();
        }

    }
}
