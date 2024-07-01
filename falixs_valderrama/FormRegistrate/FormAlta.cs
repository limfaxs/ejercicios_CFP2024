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

namespace FormRegistrate
{
    public partial class FormAlta : Form
    {
        Ingresante ingresante;

        public Ingresante Ingresante { get => ingresante; }

        public FormAlta()
        {
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            lst_paises.DataSource = new List<string>()
            {
                "Argentina","Peru","Colombia","Uruguay","Ecuador","Cuba"
            };
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int)num_edad.Value;
            string genero = string.Empty;
            //string pais = lst_paises.SelectedItem.ToString();
            string pais = lst_paises.Text;
            List<string> cursos = new List<string>();

            foreach (RadioButton rd in gpb_generos.Controls)
            {
                //Puede ir de las dos formas.
                //if (rd.Checked == true)
                if (rd.Checked)
                {
                    genero = rd.Text;
                    break;
                }
            }

            foreach (CheckBox ck in gpb_cursos.Controls)
            {
                if (ck.Checked)
                {
                    cursos.Add(ck.Text);
                }
            }

            ingresante = new Ingresante(nombre, apellido, edad, genero, pais, cursos);

            DialogResult = DialogResult.OK;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        
    }
}
