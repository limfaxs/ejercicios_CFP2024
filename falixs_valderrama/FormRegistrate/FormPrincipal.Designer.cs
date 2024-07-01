namespace FormRegistrate
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
            dgv_ingresantes = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ingresantes).BeginInit();
            SuspendLayout();
            // 
            // dgv_ingresantes
            // 
            dgv_ingresantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ingresantes.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgv_ingresantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ingresantes.Location = new Point(26, 46);
            dgv_ingresantes.Name = "dgv_ingresantes";
            dgv_ingresantes.Size = new Size(926, 295);
            dgv_ingresantes.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.Yellow;
            btn_agregar.Location = new Point(316, 347);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1047, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_ingresantes);
            ForeColor = SystemColors.ControlText;
            Name = "FormPrincipal";
            Text = "Listado de Ingresantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ingresantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ingresantes;
        private Button btn_agregar;
    }
}
