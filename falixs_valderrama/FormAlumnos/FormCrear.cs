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
    public partial class FormCrear : Form
    {
        // Atributos
        private Alumno nuevoAlumno;

        // Constructor
        public FormCrear()
        {
            InitializeComponent();
        }

        // Evento particular del formulario
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Dentro del evento me creo una instancia. y como este tiene que comunicarse,
            //Es un formulario que esta hecho para transmitir informacion.>
            nuevoAlumno = new Alumno(txt_legajo.Text, txt_nombre.Text, txt_apellido.Text);

            //En cada uno de ellos le seteo un DialogResult. y al setear un DialogResult lo que estoy haciendo es:
            //tambien diciendole que se acabo su tiempo de vida. Al terminar una respuesta, listo, puedes irte.
                //Terminado o cancelado.
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
                //Terminado o cancelado.
            this.DialogResult= DialogResult.Cancel;
        }

        // Si quiero puedo tener: Propiedades geters, seters y metodos y todo lo demas, sigue siendo una clase.
        public Alumno MiAlumno
        {
            get
            {
                return nuevoAlumno;
            }
        }
    }
}
