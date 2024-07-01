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
    public partial class FormAltaMateria : Form
    {
        // Atributo
        private Materia miMateria;

        public FormAltaMateria()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            // Nueva instancia
           // if (txt_nombre.Text is not null)           
            if (!string.IsNullOrEmpty(txt_nombre.Text))
            {
                this.miMateria = new Materia(txt_nombre.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Retorno de esa instancia
        public Materia MiMateria
        {
            get
            {
                return this.miMateria;
            }
        }
    }
}
