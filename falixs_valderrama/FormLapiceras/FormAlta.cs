using LibreriaDeLapiceras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLapiceras
{
    public partial class FormAlta : Form
    {
        Lapicera lapicera;

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            lst_colores.DataSource = new List<string>()
            {
                "Rojo","Celeste","Amarillo","Negro","Azul","Verde"
            };


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            // string marca = gpb_marcas.Text;
            //// Color color = color.get;
            // int precio = (int) num_precio.Value;
            //// lapicera = new Lapicera(color, precio);


            //DialogResult = DialogResult.OK;
            //Color color = lbl_colores.Text;
            //int precio = (int)num_precio.Value;
            //string marca = lst_colores.Text;//SelectedItem.ToString();
            //int nivelDeTinta = num;




        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
