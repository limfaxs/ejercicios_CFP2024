using LibreriaDeLapiceras;

namespace FormLapiceras
{
    public partial class FormPrincipal : Form
    {
        List<Lapicera> lapiceras;

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lapiceras = new List<Lapicera>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            //if (formAlta.DialogResult == DialogResult.OK)
            //{
                
            //}
        }

    }
}
