﻿namespace FormAuto
{
    partial class FormAuto
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
            txt_marca = new TextBox();
            txt_combustible = new TextBox();
            lbl_marca = new Label();
            lbl_combustible = new Label();
            lbl_color = new Label();
            btn_crear = new Button();
            cmb_colores = new ComboBox();
            lst_misAutos = new ListBox();
            btn_mostrar = new Button();
            btn_limpiar = new Button();
            SuspendLayout();
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(12, 34);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(140, 23);
            txt_marca.TabIndex = 0;
            // 
            // txt_combustible
            // 
            txt_combustible.Location = new Point(12, 96);
            txt_combustible.Name = "txt_combustible";
            txt_combustible.Size = new Size(140, 23);
            txt_combustible.TabIndex = 1;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(12, 16);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 3;
            lbl_marca.Text = "Marca";
            // 
            // lbl_combustible
            // 
            lbl_combustible.AutoSize = true;
            lbl_combustible.Location = new Point(12, 78);
            lbl_combustible.Name = "lbl_combustible";
            lbl_combustible.Size = new Size(122, 15);
            lbl_combustible.TabIndex = 4;
            lbl_combustible.Text = "Cant. de Combustible";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(12, 145);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(36, 15);
            lbl_color.TabIndex = 5;
            lbl_color.Text = "Color";
            // 
            // btn_crear
            // 
            btn_crear.BackColor = Color.Gold;
            btn_crear.Location = new Point(12, 230);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(75, 23);
            btn_crear.TabIndex = 6;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += button1_Click;
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(12, 163);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(139, 23);
            cmb_colores.TabIndex = 3;
            // 
            // lst_misAutos
            // 
            lst_misAutos.FormattingEnabled = true;
            lst_misAutos.ItemHeight = 15;
            lst_misAutos.Location = new Point(298, 19);
            lst_misAutos.Name = "lst_misAutos";
            lst_misAutos.Size = new Size(426, 319);
            lst_misAutos.TabIndex = 7;
            // 
            // btn_mostrar
            // 
            btn_mostrar.BackColor = Color.Lime;
            btn_mostrar.Location = new Point(320, 372);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 8;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = false;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.DarkOrange;
            btn_limpiar.Location = new Point(605, 372);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 9;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_mostrar);
            Controls.Add(lst_misAutos);
            Controls.Add(cmb_colores);
            Controls.Add(btn_crear);
            Controls.Add(lbl_color);
            Controls.Add(lbl_combustible);
            Controls.Add(lbl_marca);
            Controls.Add(txt_combustible);
            Controls.Add(txt_marca);
            ForeColor = SystemColors.ControlText;
            Name = "FormAuto";
            Text = "Mis Autos";
            Load += FormAuto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_marca;
        private TextBox txt_combustible;
        private Label lbl_marca;
        private Label lbl_combustible;
        private Label lbl_color;
        private Button btn_crear;
        private ComboBox cmb_colores;
        private ListBox lst_misAutos;
        private Button btn_mostrar;
        private Button btn_limpiar;
    }
}
