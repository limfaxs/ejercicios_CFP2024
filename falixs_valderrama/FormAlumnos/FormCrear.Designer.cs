namespace FormAlumnos
{
    partial class FormCrear
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
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            txt_legajo = new TextBox();
            lbl_legajo = new Label();
            lbl_nombre = new Label();
            lbl_Apellido = new Label();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(255, 128, 255);
            txt_apellido.Location = new Point(165, 294);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 0;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(255, 192, 128);
            txt_nombre.Location = new Point(165, 167);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 1;
            // 
            // txt_legajo
            // 
            txt_legajo.BackColor = Color.FromArgb(255, 255, 128);
            txt_legajo.Location = new Point(165, 28);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(100, 23);
            txt_legajo.TabIndex = 2;
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.Location = new Point(32, 28);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(42, 15);
            lbl_legajo.TabIndex = 3;
            lbl_legajo.Text = "Legajo";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(32, 170);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 4;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(32, 302);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 5;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Lime;
            btn_aceptar.Location = new Point(48, 395);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 0);
            btn_cancelar.Location = new Point(190, 395);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(391, 450);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_legajo);
            Controls.Add(txt_legajo);
            Controls.Add(txt_nombre);
            Controls.Add(txt_apellido);
            Name = "FormCrear";
            Text = "Alta alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private TextBox txt_legajo;
        private Label lbl_legajo;
        private Label lbl_nombre;
        private Label lbl_Apellido;
        private Button btn_aceptar;
        private Button btn_cancelar;
    }
}