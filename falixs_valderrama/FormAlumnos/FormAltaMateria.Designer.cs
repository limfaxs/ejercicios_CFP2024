﻿namespace FormAlumnos
{
    partial class FormAltaMateria
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
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Lime;
            btn_cancelar.Location = new Point(32, 116);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.FromArgb(255, 128, 0);
            btn_aceptar.Location = new Point(125, 116);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 1;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(192, 192, 255);
            txt_nombre.Location = new Point(100, 35);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(32, 38);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "Nombre";
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(222, 183);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_nombre);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Name = "FormAltaMateria";
            Text = "Alta de materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_aceptar;
        private TextBox txt_nombre;
        private Label lbl_nombre;
    }
}