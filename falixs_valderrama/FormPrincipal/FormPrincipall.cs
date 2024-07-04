using ClaseDeComputadora;

namespace FormPrincipal
{
    public partial class FormPrincipall : Form
    {
        public partial class FormPrincipal : Form
        {
            List<Computadora> ingresantes;


            public FormPrincipal()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                ingresantes = new List<Computadora>();
            }

            private void btn_agregar_Click(object sender, EventArgs e)
            {
                FormAlta formAlta = new FormAlta();
                // Sirve para llamar o abrir una nueva instancia del form.
                formAlta.ShowDialog();

                //if (formAlta.DialogResult == DialogResult.OK)
                //{
                //    Computadora.Add(formAlta.computadora);
                //    dgv_computadora.DataSource = null;
                //    dgv_computadora.DataSource = ingresantes;

                //}



            }
        }
    }
}  
