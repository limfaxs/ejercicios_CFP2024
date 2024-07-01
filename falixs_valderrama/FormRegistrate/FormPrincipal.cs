using LibreriaDeStudiante;

namespace FormRegistrate
{
    public partial class FormPrincipal : Form
    {
        List<Ingresante> ingresantes;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ingresantes = new List<Ingresante>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            // Sirve para llamar o abrir una nueva instancia del form.
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                ingresantes.Add(formAlta.Ingresante);
                dgv_ingresantes.DataSource = null;
                dgv_ingresantes.DataSource = ingresantes;

            }



        }



    }
}
