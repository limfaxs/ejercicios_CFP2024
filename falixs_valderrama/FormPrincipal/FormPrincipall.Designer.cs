namespace FormPrincipal
{
    partial class FormPrincipall
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
            dgv_computadora = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_computadora).BeginInit();
            // 
            // dgv_computadora
            // 
            dgv_computadora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_computadora.Location = new Point(12, 29);
            dgv_computadora.Name = "dgv_computadora";
            dgv_computadora.Size = new Size(716, 360);
            dgv_computadora.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(328, 395);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agrgar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_computadora);
            Name = "FormPrincipall";
            Text = "Computadoras";
            ((System.ComponentModel.ISupportInitialize)dgv_computadora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_computadora;
        private Button btn_agregar;
    }
}
