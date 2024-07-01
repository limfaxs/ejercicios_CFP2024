namespace FormRegistrate
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
            gpb_datosingresante = new GroupBox();
            num_edad = new NumericUpDown();
            txt_apellido = new TextBox();
            lbl_edad = new Label();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_pais = new Label();
            gpb_generos = new GroupBox();
            rdb_nobinario = new RadioButton();
            rdb_femenino = new RadioButton();
            rdb_masculino = new RadioButton();
            gpb_cursos = new GroupBox();
            chk_javascript = new CheckBox();
            chk_mode = new CheckBox();
            chk_python = new CheckBox();
            chk_angular = new CheckBox();
            chk_csharp = new CheckBox();
            lst_paises = new ListBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            gpb_datosingresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).BeginInit();
            gpb_generos.SuspendLayout();
            gpb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_datosingresante
            // 
            gpb_datosingresante.Controls.Add(num_edad);
            gpb_datosingresante.Controls.Add(txt_apellido);
            gpb_datosingresante.Controls.Add(lbl_edad);
            gpb_datosingresante.Controls.Add(txt_nombre);
            gpb_datosingresante.Controls.Add(lbl_nombre);
            gpb_datosingresante.Controls.Add(lbl_apellido);
            gpb_datosingresante.Location = new Point(12, -2);
            gpb_datosingresante.Name = "gpb_datosingresante";
            gpb_datosingresante.Size = new Size(258, 223);
            gpb_datosingresante.TabIndex = 0;
            gpb_datosingresante.TabStop = false;
            gpb_datosingresante.Text = "Datos del ingresante";
            // 
            // num_edad
            // 
            num_edad.BackColor = Color.FromArgb(192, 192, 255);
            num_edad.Location = new Point(66, 177);
            num_edad.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            num_edad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(120, 23);
            num_edad.TabIndex = 2;
            num_edad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(192, 192, 255);
            txt_apellido.Location = new Point(66, 108);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.PlaceholderText = "ingrese su apellido";
            txt_apellido.Size = new Size(165, 23);
            txt_apellido.TabIndex = 1;
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(6, 179);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(33, 15);
            lbl_edad.TabIndex = 5;
            lbl_edad.Text = "Edad";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(192, 192, 255);
            txt_nombre.Location = new Point(66, 43);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "ingrese su nombre";
            txt_nombre.Size = new Size(165, 23);
            txt_nombre.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(6, 46);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 3;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(6, 111);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 4;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(12, 264);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 6;
            lbl_pais.Text = "Pais";
            // 
            // gpb_generos
            // 
            gpb_generos.Controls.Add(rdb_nobinario);
            gpb_generos.Controls.Add(rdb_femenino);
            gpb_generos.Controls.Add(rdb_masculino);
            gpb_generos.Location = new Point(319, 0);
            gpb_generos.Name = "gpb_generos";
            gpb_generos.Size = new Size(200, 100);
            gpb_generos.TabIndex = 0;
            gpb_generos.TabStop = false;
            gpb_generos.Text = "Genero";
            // 
            // rdb_nobinario
            // 
            rdb_nobinario.AutoSize = true;
            rdb_nobinario.Location = new Point(0, 75);
            rdb_nobinario.Name = "rdb_nobinario";
            rdb_nobinario.Size = new Size(81, 19);
            rdb_nobinario.TabIndex = 2;
            rdb_nobinario.TabStop = true;
            rdb_nobinario.Text = "No Binario";
            rdb_nobinario.UseVisualStyleBackColor = true;
            // 
            // rdb_femenino
            // 
            rdb_femenino.AutoSize = true;
            rdb_femenino.Location = new Point(0, 44);
            rdb_femenino.Name = "rdb_femenino";
            rdb_femenino.Size = new Size(78, 19);
            rdb_femenino.TabIndex = 1;
            rdb_femenino.TabStop = true;
            rdb_femenino.Text = "Femenino";
            rdb_femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            rdb_masculino.AutoSize = true;
            rdb_masculino.ForeColor = SystemColors.ControlText;
            rdb_masculino.Location = new Point(0, 19);
            rdb_masculino.Name = "rdb_masculino";
            rdb_masculino.Size = new Size(80, 19);
            rdb_masculino.TabIndex = 0;
            rdb_masculino.TabStop = true;
            rdb_masculino.Text = "Masculino";
            rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_cursos
            // 
            gpb_cursos.Controls.Add(chk_javascript);
            gpb_cursos.Controls.Add(chk_mode);
            gpb_cursos.Controls.Add(chk_python);
            gpb_cursos.Controls.Add(chk_angular);
            gpb_cursos.Controls.Add(chk_csharp);
            gpb_cursos.Location = new Point(319, 179);
            gpb_cursos.Name = "gpb_cursos";
            gpb_cursos.Size = new Size(200, 154);
            gpb_cursos.TabIndex = 0;
            gpb_cursos.TabStop = false;
            gpb_cursos.Text = "Cursos";
            // 
            // chk_javascript
            // 
            chk_javascript.AutoSize = true;
            chk_javascript.Location = new Point(0, 122);
            chk_javascript.Name = "chk_javascript";
            chk_javascript.Size = new Size(77, 19);
            chk_javascript.TabIndex = 4;
            chk_javascript.Text = "Javascript";
            chk_javascript.UseVisualStyleBackColor = true;
            // 
            // chk_mode
            // 
            chk_mode.AutoSize = true;
            chk_mode.Location = new Point(0, 97);
            chk_mode.Name = "chk_mode";
            chk_mode.Size = new Size(68, 19);
            chk_mode.TabIndex = 3;
            chk_mode.Text = "Mode.js";
            chk_mode.UseVisualStyleBackColor = true;
            // 
            // chk_python
            // 
            chk_python.AutoSize = true;
            chk_python.Location = new Point(0, 72);
            chk_python.Name = "chk_python";
            chk_python.Size = new Size(64, 19);
            chk_python.TabIndex = 2;
            chk_python.Text = "Python";
            chk_python.UseVisualStyleBackColor = true;
            // 
            // chk_angular
            // 
            chk_angular.AutoSize = true;
            chk_angular.Location = new Point(0, 47);
            chk_angular.Name = "chk_angular";
            chk_angular.Size = new Size(68, 19);
            chk_angular.TabIndex = 1;
            chk_angular.Text = "Angular";
            chk_angular.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            chk_csharp.AutoSize = true;
            chk_csharp.Location = new Point(0, 22);
            chk_csharp.Name = "chk_csharp";
            chk_csharp.Size = new Size(41, 19);
            chk_csharp.TabIndex = 0;
            chk_csharp.Text = "C#";
            chk_csharp.UseVisualStyleBackColor = true;
            // 
            // lst_paises
            // 
            lst_paises.BackColor = Color.FromArgb(192, 192, 255);
            lst_paises.FormattingEnabled = true;
            lst_paises.ItemHeight = 15;
            lst_paises.Location = new Point(12, 290);
            lst_paises.Name = "lst_paises";
            lst_paises.Size = new Size(258, 94);
            lst_paises.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 0);
            btn_cancelar.Location = new Point(319, 392);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.Lime;
            btn_agregar.Location = new Point(444, 392);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(545, 450);
            Controls.Add(lbl_pais);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(lst_paises);
            Controls.Add(gpb_generos);
            Controls.Add(gpb_cursos);
            Controls.Add(gpb_datosingresante);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            gpb_datosingresante.ResumeLayout(false);
            gpb_datosingresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).EndInit();
            gpb_generos.ResumeLayout(false);
            gpb_generos.PerformLayout();
            gpb_cursos.ResumeLayout(false);
            gpb_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_datosingresante;
        private GroupBox gpb_generos;
        private RadioButton rdb_nobinario;
        private RadioButton rdb_femenino;
        private RadioButton rdb_masculino;
        private GroupBox gpb_cursos;
        private CheckBox chk_javascript;
        private CheckBox chk_mode;
        private CheckBox chk_python;
        private CheckBox chk_angular;
        private CheckBox chk_csharp;
        private ListBox lst_paises;
        private Button btn_cancelar;
        private Button btn_agregar;
        private Label lbl_pais;
        private Label lbl_edad;
        private Label lbl_apellido;
        private Label lbl_nombre;
        private NumericUpDown num_edad;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
    }
}