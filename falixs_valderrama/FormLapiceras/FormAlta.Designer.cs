namespace FormLapiceras
{
    partial class FormAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpb_marcas = new GroupBox();
            red_pelikan = new RadioButton();
            rdb_fabercastell = new RadioButton();
            rdb_maped = new RadioButton();
            lst_colores = new ListBox();
            btn_agregar = new Button();
            btn_cancelar = new Button();
            lbl_precio = new Label();
            lbl_colores = new Label();
            cmb_precio = new ComboBox();
            gpb_marcas.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_marcas
            // 
            gpb_marcas.Controls.Add(red_pelikan);
            gpb_marcas.Controls.Add(rdb_fabercastell);
            gpb_marcas.Controls.Add(rdb_maped);
            gpb_marcas.Location = new Point(28, 12);
            gpb_marcas.Name = "gpb_marcas";
            gpb_marcas.Size = new Size(200, 111);
            gpb_marcas.TabIndex = 0;
            gpb_marcas.TabStop = false;
            gpb_marcas.Text = "Marcas";
            // 
            // red_pelikan
            // 
            red_pelikan.AutoSize = true;
            red_pelikan.Location = new Point(6, 47);
            red_pelikan.Name = "red_pelikan";
            red_pelikan.Size = new Size(63, 19);
            red_pelikan.TabIndex = 4;
            red_pelikan.TabStop = true;
            red_pelikan.Text = "pelikan";
            red_pelikan.UseVisualStyleBackColor = true;
            // 
            // rdb_fabercastell
            // 
            rdb_fabercastell.AutoSize = true;
            rdb_fabercastell.Location = new Point(6, 22);
            rdb_fabercastell.Name = "rdb_fabercastell";
            rdb_fabercastell.Size = new Size(90, 19);
            rdb_fabercastell.TabIndex = 3;
            rdb_fabercastell.TabStop = true;
            rdb_fabercastell.Text = "Faber castell";
            rdb_fabercastell.UseVisualStyleBackColor = true;
            // 
            // rdb_maped
            // 
            rdb_maped.AutoSize = true;
            rdb_maped.Location = new Point(6, 72);
            rdb_maped.Name = "rdb_maped";
            rdb_maped.Size = new Size(62, 19);
            rdb_maped.TabIndex = 5;
            rdb_maped.TabStop = true;
            rdb_maped.Text = "Maped";
            rdb_maped.UseVisualStyleBackColor = true;
            // 
            // lst_colores
            // 
            lst_colores.FormattingEnabled = true;
            lst_colores.ItemHeight = 15;
            lst_colores.Location = new Point(28, 249);
            lst_colores.Name = "lst_colores";
            lst_colores.Size = new Size(184, 139);
            lst_colores.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(208, 399);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(311, 399);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click_1;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(265, 9);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(40, 15);
            lbl_precio.TabIndex = 5;
            lbl_precio.Text = "Precio";
            // 
            // lbl_colores
            // 
            lbl_colores.AutoSize = true;
            lbl_colores.Location = new Point(28, 222);
            lbl_colores.Name = "lbl_colores";
            lbl_colores.Size = new Size(47, 15);
            lbl_colores.TabIndex = 6;
            lbl_colores.Text = "Colores";
            // 
            // cmb_precio
            // 
            cmb_precio.FormattingEnabled = true;
            cmb_precio.Location = new Point(265, 30);
            cmb_precio.Name = "cmb_precio";
            cmb_precio.Size = new Size(121, 23);
            cmb_precio.TabIndex = 7;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_precio);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_colores);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(lst_colores);
            Controls.Add(gpb_marcas);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            gpb_marcas.ResumeLayout(false);
            gpb_marcas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_marcas;
        private RadioButton red_pelikan;
        private RadioButton rdb_fabercastell;
        private ListBox lst_colores;
        private Button btn_agregar;
        private Button btn_cancelar;
        private RadioButton rdb_maped;
        private Label lbl_precio;
        private Label lbl_colores;
        private NumericUpDown num_precio;
        private ComboBox cmb_precio;
    }
}