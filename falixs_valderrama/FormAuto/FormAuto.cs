using PrimeraEvaluacion;
using LibreriaDeFunciones;
using System.Diagnostics;
using System.Windows.Forms;

namespace FormAuto
{
    public partial class FormAuto : Form
    {
        List<Auto> misAutos; //= new List<Auto>();
        //
        //int cantidadDeAutos;

        public FormAuto()
        {
            InitializeComponent();

            this.misAutos = new List<Auto>();

        }
        //
        private void FormAuto_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.cargarCMB(Auto.ColoresValidos());
            //this.cmb_colores.Items.AddRange(Auto.ColoresValidos().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            Color color = (Color)this.cmb_colores.SelectedItem;
            //string colorTxt = this.cmb_colores.Text;
            // string color = this.txt_color.Text;
            //string color = this.cmb_colores.Text;
            DialogResult respuesta;
            

            
            //Auto miAuto = new Auto(marca, combustible, color);

            //double comValido
            if (this.ValidarEntradas(marca, combustible))
            {
                Auto miAuto = new Auto(marca, combustible, color);
               
                respuesta = MessageBox.Show($"Desea agregar este AUTO{miAuto.GetMarca()}?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    MessageBox.Show("Auto no agregado");
                }
                else
                {
                    misAutos.Add(miAuto);
                }

                this.limpiar();
            }


            //Auto miAuto = new Auto(marca, combustible, color);

            ///misAutos.Add(miAuto);
            ///

            //Mensaje - Titulo - Botones - Icono
            //respuesta = MessageBox.Show("Desea agregar este AUTO?", "Agregar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //respuesta = MessageBox.Show($"Desea agregar el auto{miAuto.GetMarca()}?", "Agregar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            //switch (respuesta)
            //{
            //    case DialogResult.Yes:
            //        MessageBox.Show("Apreto el boton Yes");
            //        break;
            //    case DialogResult.No:
            //        MessageBox.Show("Apreto el boton No");
            //        break;
            //    case DialogResult.Cancel:
            //        MessageBox.Show("Apreto el boton Cancel");
            //        break;
            //}

            //Mensaje - Titulo - Botones - Icono
            //respuesta = MessageBox.Show("Desea agregar este AUTO?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (respuesta == DialogResult.No)
            //{
            //    MessageBox.Show("Auto no agregado");
            //    //misAutos.Add(miAuto);
            //}
            //else
            //{
            //    misAutos.Add(miAuto);
            //    //MessageBox.Show("Auto no agregado");
            //}


            // misAutos.Add(miAuto);

            //this.lst_misAutos.Items.Add(miAuto.AutoToString());
            //this.lst_misAutos.Items.AddRange(misAutos.ToArray());

            this.limpiar();
        }


        private void limpiar()
        {
            // this.txt_color.Text = string.Empty;
            this.cmb_colores.Text = string.Empty;
            this.txt_combustible.Text = string.Empty;
            this.txt_marca.Text = string.Empty;

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this.VaciarLst();
            //this.lst_misAutos.Items.AddRange(misAutos.ToArray());
            this.lst_misAutos.DataSource = misAutos;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //this.lst_misAutos.Items.Clear();
            this.VaciarLst();
        }
        private void VaciarLst()
        {
            this.lst_misAutos.Items.Clear();
        }

        private bool ValidarEntradas(string marca, string combustible)
        {
            bool ok = true;
            if (!MisFunciones.EsSoloLetras(marca))
            {
                MessageBox.Show("La marca deben ser solo letras");
                ok = false;
            }
            if (!MisFunciones.EsNumerico(combustible))
            {
                MessageBox.Show("El combustible debe ser numerico");
                ok = false;
            }
            return ok;
        }

        //private void cargarCMB(List<Color> colores)
        //{
        //    foreach (Color color in colores)
        //    {
        //        this.cmb_colores.Items.Add(color);
        //    }
        //}

        private void cargarCMB(List<Color> colores)
        {
           this.cmb_colores.DataSource = colores;
        }


    }
}
