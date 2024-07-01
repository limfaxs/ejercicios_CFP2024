using LibreriaDeStudiante;

namespace FormAlumnos
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos;
        //
        private List<Materia> materias;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.alumnos = new List<Alumno>();
            this.materias = new List<Materia>();
            this.alumnos = Alumno.ListaAlumnos();

            this.lst_alumnos.DataSource = alumnos;
        }

        // Marcar como comentario
        ////private void btn_mostrar_Click(object sender, EventArgs e)
        ////{
        ////    CargarDgv();
        ////    //
        ////    //CargarLstAlumnos();
        ////    //this.dgv_informacion.DataSource = alumnos;
        ////}

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Lo que se haces es: Crear una instancia del formulario al que estoy llamando.
            //Le doy un nombre, lo instancio y despues.>
            FormCrear formAlta = new FormCrear();
            // hacen que se muestre esa instancia que acabo de crear.
            formAlta.ShowDialog(); //Lo muestro

            //Y despues puedo evaluar que resultados me dio. si me dio un resultado ok
            // o un resultado cancel, o lo que sea. y en base a esa respuesta, hago o no,
            // determinada cosa. En este caso yo lo agrego.
            //podria tener tambien la validacion de que si DialogResult fue OK y a su ves 
            //decir que si.Ejemplo:
            //if (formAlta.DialogResult == DialogResult.OK && formAlta.MiAlumno is not null) osea que lo agregue.
            if (formAlta.DialogResult == DialogResult.OK)
            {
                alumnos.Add(formAlta.MiAlumno);
                CargarLstAlumnos();
                //lst_alumnos.DataSource = null;
                //lst_alumnos.DataSource = alumnos;

            }

            //Sirve para que se muestre
            //DialogResult rsp = MessageBox.Show("hola", "saludo", MessageBoxButtons.YesNo);

            //if (rsp == DialogResult.OK)
            //{

            //}
        }

        private void CargarLstAlumnos()
        {
            lst_alumnos.DataSource = null;
            lst_alumnos.DataSource = alumnos;
        }

        //
        private void CargarLstMaterias()
        {
            lst_materias.DataSource = null;
            lst_materias.DataSource = materias;
        }

        // Marcar como comentario
        //private void CargarDgv()
        //{
        //    dgv_informacion.DataSource = null;
        //    dgv_informacion.DataSource = alumnos;
        //}

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();

            // Marcar como comentario
            //foreach (Alumno item in alumnos)
            //{
            //    item.NotaPrimerParcial = rdn.Next(1, 10);
            //    item.NotaSegundoParcial = rdn.Next(1, 10);
            //}

        }

        private void btn_AgregarMateria_Click(object sender, EventArgs e)
        {
            FormAltaMateria formAltaMateria = new FormAltaMateria();

            formAltaMateria.ShowDialog();

            if (formAltaMateria.DialogResult == DialogResult.OK)
            {
                materias.Add(formAltaMateria.MiMateria);
                CargarLstMaterias();
            }

        }

        private void btn_EstadoAcademico_Click(object sender, EventArgs e)
        {
            Alumno alumno = alumnos[0];
            List<Materia> lista = materias;
            string carrera = "Trayecto programacion";

            FormEstadoAcademico estadoAcademico = new FormEstadoAcademico(alumno, lista, carrera);


            estadoAcademico.ShowDialog();

        }
    }
}
