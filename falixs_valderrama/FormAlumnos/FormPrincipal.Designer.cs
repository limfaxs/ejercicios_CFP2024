namespace FormAlumnos
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
            lst_alumnos = new ListBox();
            btn_agregar = new Button();
            lbl_Alumnos = new Label();
            btn_AgregarMateria = new Button();
            lst_materias = new ListBox();
            lbl_materia = new Label();
            btn_EstadoAcademico = new Button();
            SuspendLayout();
            // 
            // lst_alumnos
            // 
            lst_alumnos.BackColor = SystemColors.GradientActiveCaption;
            lst_alumnos.FormattingEnabled = true;
            lst_alumnos.ItemHeight = 15;
            lst_alumnos.Location = new Point(12, 27);
            lst_alumnos.Name = "lst_alumnos";
            lst_alumnos.Size = new Size(201, 334);
            lst_alumnos.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.Lime;
            btn_agregar.Location = new Point(56, 378);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(132, 23);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar Alumno";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lbl_Alumnos
            // 
            lbl_Alumnos.AutoSize = true;
            lbl_Alumnos.Location = new Point(78, 9);
            lbl_Alumnos.Name = "lbl_Alumnos";
            lbl_Alumnos.Size = new Size(55, 15);
            lbl_Alumnos.TabIndex = 5;
            lbl_Alumnos.Text = "Alumnos";
            // 
            // btn_AgregarMateria
            // 
            btn_AgregarMateria.BackColor = Color.MediumOrchid;
            btn_AgregarMateria.Location = new Point(280, 378);
            btn_AgregarMateria.Name = "btn_AgregarMateria";
            btn_AgregarMateria.Size = new Size(107, 23);
            btn_AgregarMateria.TabIndex = 8;
            btn_AgregarMateria.Text = "Agregar Materia";
            btn_AgregarMateria.UseVisualStyleBackColor = false;
            btn_AgregarMateria.Click += btn_AgregarMateria_Click;
            // 
            // lst_materias
            // 
            lst_materias.BackColor = SystemColors.GradientActiveCaption;
            lst_materias.FormattingEnabled = true;
            lst_materias.ItemHeight = 15;
            lst_materias.Location = new Point(239, 27);
            lst_materias.Name = "lst_materias";
            lst_materias.Size = new Size(201, 334);
            lst_materias.TabIndex = 9;
            // 
            // lbl_materia
            // 
            lbl_materia.AutoSize = true;
            lbl_materia.Location = new Point(308, 9);
            lbl_materia.Name = "lbl_materia";
            lbl_materia.Size = new Size(52, 15);
            lbl_materia.TabIndex = 10;
            lbl_materia.Text = "Materias";
            // 
            // btn_EstadoAcademico
            // 
            btn_EstadoAcademico.BackColor = Color.MediumOrchid;
            btn_EstadoAcademico.Location = new Point(533, 378);
            btn_EstadoAcademico.Name = "btn_EstadoAcademico";
            btn_EstadoAcademico.Size = new Size(175, 23);
            btn_EstadoAcademico.TabIndex = 11;
            btn_EstadoAcademico.Text = "Crear Estado Academico";
            btn_EstadoAcademico.UseVisualStyleBackColor = false;
            btn_EstadoAcademico.Click += btn_EstadoAcademico_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(927, 430);
            Controls.Add(btn_EstadoAcademico);
            Controls.Add(lbl_materia);
            Controls.Add(lst_materias);
            Controls.Add(btn_AgregarMateria);
            Controls.Add(lbl_Alumnos);
            Controls.Add(btn_agregar);
            Controls.Add(lst_alumnos);
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_alumnos;
        private Button btn_agregar;
        private Label lbl_Alumnos;
        private Button btn_AgregarMateria;
        private ListBox lst_materias;
        private Label lbl_materia;
        private Button btn_EstadoAcademico;
    }
}
