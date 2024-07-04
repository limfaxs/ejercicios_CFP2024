using ClaseDeComputadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormAlta : Form
    {
        public Computadora NuevaComputadora { get; private set; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            // Cargar ComboBox con los tipos de procesadores
            cmb_procesadores.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validar y crear nueva computadora
            if (ValidarCampos())
            {
                int memoriaRam = (int)nudMemoriaRAM.Value;
                int capacidadDisco = (int)nudCapacidadDisco.Value;
                string procesador = cmb_Procesador.ToString();
                string sistemaOperativo = txtSistemaOperativo.Text;

                NuevaComputadora = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);

                foreach (string programa in lbProgramas.Controls)
                {
                    NuevaComputadora.AgregarPrograma(programa);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidarCampos()
        {
            // Aquí puedes implementar validaciones adicionales según tus necesidades
            if (string.IsNullOrWhiteSpace(txtSistemaOperativo.Text))
            {
                MessageBox.Show("Debe ingresar el sistema operativo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }

}
