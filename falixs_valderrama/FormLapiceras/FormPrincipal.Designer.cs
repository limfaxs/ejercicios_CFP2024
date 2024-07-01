namespace FormLapiceras
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_lapicera = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_lapicera).BeginInit();
            SuspendLayout();
            // 
            // dgv_lapicera
            // 
            dgv_lapicera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lapicera.Location = new Point(12, 43);
            dgv_lapicera.Name = "dgv_lapicera";
            dgv_lapicera.Size = new Size(743, 301);
            dgv_lapicera.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(379, 381);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_lapicera);
            Name = "FormPrincipal";
            Text = "Listado de lapiceras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lapicera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_lapicera;
        private Button btn_agregar;
    }
}
