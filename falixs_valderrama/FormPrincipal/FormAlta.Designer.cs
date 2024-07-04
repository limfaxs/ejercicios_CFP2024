namespace FormPrincipal
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
            gpb_hadware = new GroupBox();
            txt_disco = new TextBox();
            txt_memoriaran = new TextBox();
            nudMemoriaRAM = new NumericUpDown();
            nudCapacidadDisco = new NumericUpDown();
            cmb_Procesador = new TextBox();
            chk_office = new CheckBox();
            rdb_windows = new RadioButton();
            cmb_procesadores = new ComboBox();
            btn_agregar = new Button();
            btn_cancelar = new Button();
            txtSistemaOperativo = new GroupBox();
            rbt_macos = new RadioButton();
            rbt_linux = new RadioButton();
            lbProgramas = new GroupBox();
            chk_avast = new CheckBox();
            chk_dropbox = new CheckBox();
            chk_winrar = new CheckBox();
            chk_adobereader = new CheckBox();
            gpb_hadware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMemoriaRAM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidadDisco).BeginInit();
            txtSistemaOperativo.SuspendLayout();
            lbProgramas.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_hadware
            // 
            gpb_hadware.Controls.Add(txt_disco);
            gpb_hadware.Controls.Add(txt_memoriaran);
            gpb_hadware.Controls.Add(nudMemoriaRAM);
            gpb_hadware.Controls.Add(nudCapacidadDisco);
            gpb_hadware.Controls.Add(cmb_Procesador);
            gpb_hadware.Location = new Point(12, 34);
            gpb_hadware.Name = "gpb_hadware";
            gpb_hadware.Size = new Size(410, 208);
            gpb_hadware.TabIndex = 0;
            gpb_hadware.TabStop = false;
            gpb_hadware.Text = "Hadware";
            // 
            // txt_disco
            // 
            txt_disco.Location = new Point(0, 149);
            txt_disco.Name = "txt_disco";
            txt_disco.Size = new Size(100, 23);
            txt_disco.TabIndex = 6;
            txt_disco.Text = "Disco";
            // 
            // txt_memoriaran
            // 
            txt_memoriaran.Location = new Point(0, 90);
            txt_memoriaran.Name = "txt_memoriaran";
            txt_memoriaran.Size = new Size(100, 23);
            txt_memoriaran.TabIndex = 5;
            txt_memoriaran.Text = "Memoria Ram";
            // 
            // nudMemoriaRAM
            // 
            nudMemoriaRAM.Location = new Point(127, 90);
            nudMemoriaRAM.Name = "nudMemoriaRAM";
            nudMemoriaRAM.Size = new Size(120, 23);
            nudMemoriaRAM.TabIndex = 4;
            // 
            // nudCapacidadDisco
            // 
            nudCapacidadDisco.Location = new Point(126, 147);
            nudCapacidadDisco.Name = "nudCapacidadDisco";
            nudCapacidadDisco.Size = new Size(120, 23);
            nudCapacidadDisco.TabIndex = 3;
            // 
            // cmb_Procesador
            // 
            cmb_Procesador.Location = new Point(0, 37);
            cmb_Procesador.Name = "cmb_Procesador";
            cmb_Procesador.Size = new Size(100, 23);
            cmb_Procesador.TabIndex = 4;
            cmb_Procesador.Text = "Procesador";
            // 
            // chk_office
            // 
            chk_office.AutoSize = true;
            chk_office.Location = new Point(6, 32);
            chk_office.Name = "chk_office";
            chk_office.Size = new Size(58, 19);
            chk_office.TabIndex = 0;
            chk_office.Text = "Office";
            chk_office.UseVisualStyleBackColor = true;
            // 
            // rdb_windows
            // 
            rdb_windows.AutoSize = true;
            rdb_windows.Location = new Point(6, 22);
            rdb_windows.Name = "rdb_windows";
            rdb_windows.Size = new Size(74, 19);
            rdb_windows.TabIndex = 1;
            rdb_windows.TabStop = true;
            rdb_windows.Text = "Windows";
            rdb_windows.UseVisualStyleBackColor = true;
            // 
            // cmb_procesadores
            // 
            cmb_procesadores.FormattingEnabled = true;
            cmb_procesadores.Location = new Point(138, 71);
            cmb_procesadores.Name = "cmb_procesadores";
            cmb_procesadores.Size = new Size(121, 23);
            cmb_procesadores.TabIndex = 2;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(595, 406);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 5;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(482, 406);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txtSistemaOperativo
            // 
            txtSistemaOperativo.Controls.Add(rbt_macos);
            txtSistemaOperativo.Controls.Add(rbt_linux);
            txtSistemaOperativo.Controls.Add(rdb_windows);
            txtSistemaOperativo.Location = new Point(493, 12);
            txtSistemaOperativo.Name = "txtSistemaOperativo";
            txtSistemaOperativo.Size = new Size(144, 122);
            txtSistemaOperativo.TabIndex = 7;
            txtSistemaOperativo.TabStop = false;
            txtSistemaOperativo.Text = "Sistema Operativo";
            // 
            // rbt_macos
            // 
            rbt_macos.AutoSize = true;
            rbt_macos.Location = new Point(6, 72);
            rbt_macos.Name = "rbt_macos";
            rbt_macos.Size = new Size(63, 19);
            rbt_macos.TabIndex = 3;
            rbt_macos.TabStop = true;
            rbt_macos.Text = "MacOS";
            rbt_macos.UseVisualStyleBackColor = true;
            // 
            // rbt_linux
            // 
            rbt_linux.AutoSize = true;
            rbt_linux.Location = new Point(6, 47);
            rbt_linux.Name = "rbt_linux";
            rbt_linux.Size = new Size(54, 19);
            rbt_linux.TabIndex = 2;
            rbt_linux.TabStop = true;
            rbt_linux.Text = "Linux";
            rbt_linux.UseVisualStyleBackColor = true;
            // 
            // lbProgramas
            // 
            lbProgramas.Controls.Add(chk_avast);
            lbProgramas.Controls.Add(chk_dropbox);
            lbProgramas.Controls.Add(chk_winrar);
            lbProgramas.Controls.Add(chk_adobereader);
            lbProgramas.Controls.Add(chk_office);
            lbProgramas.Location = new Point(499, 153);
            lbProgramas.Name = "lbProgramas";
            lbProgramas.Size = new Size(171, 235);
            lbProgramas.TabIndex = 8;
            lbProgramas.TabStop = false;
            lbProgramas.Text = "Programas";
            // 
            // chk_avast
            // 
            chk_avast.AutoSize = true;
            chk_avast.Location = new Point(6, 132);
            chk_avast.Name = "chk_avast";
            chk_avast.Size = new Size(55, 19);
            chk_avast.TabIndex = 4;
            chk_avast.Text = "Avast";
            chk_avast.UseVisualStyleBackColor = true;
            // 
            // chk_dropbox
            // 
            chk_dropbox.AutoSize = true;
            chk_dropbox.Location = new Point(6, 107);
            chk_dropbox.Name = "chk_dropbox";
            chk_dropbox.Size = new Size(72, 19);
            chk_dropbox.TabIndex = 3;
            chk_dropbox.Text = "Dropbox";
            chk_dropbox.UseVisualStyleBackColor = true;
            // 
            // chk_winrar
            // 
            chk_winrar.AutoSize = true;
            chk_winrar.Location = new Point(6, 82);
            chk_winrar.Name = "chk_winrar";
            chk_winrar.Size = new Size(61, 19);
            chk_winrar.TabIndex = 2;
            chk_winrar.Text = "Winrar";
            chk_winrar.UseVisualStyleBackColor = true;
            // 
            // chk_adobereader
            // 
            chk_adobereader.AutoSize = true;
            chk_adobereader.Location = new Point(6, 57);
            chk_adobereader.Name = "chk_adobereader";
            chk_adobereader.Size = new Size(100, 19);
            chk_adobereader.TabIndex = 1;
            chk_adobereader.Text = "Adobe Reader";
            chk_adobereader.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbProgramas);
            Controls.Add(txtSistemaOperativo);
            Controls.Add(cmb_procesadores);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(gpb_hadware);
            Name = "FormAlta";
            Text = "FormAlta";
            gpb_hadware.ResumeLayout(false);
            gpb_hadware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMemoriaRAM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidadDisco).EndInit();
            txtSistemaOperativo.ResumeLayout(false);
            txtSistemaOperativo.PerformLayout();
            lbProgramas.ResumeLayout(false);
            lbProgramas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_hadware;
        private CheckBox chk_office;
        private RadioButton rdb_windows;
        private ComboBox cmb_procesadores;
        private NumericUpDown nudCapacidadDisco;
        private TextBox cmb_Procesador;
        private Button btn_agregar;
        private Button btn_cancelar;
        private NumericUpDown nudMemoriaRAM;
        private GroupBox txtSistemaOperativo;
        private RadioButton rbt_macos;
        private RadioButton rbt_linux;
        private GroupBox lbProgramas;
        private CheckBox chk_avast;
        private CheckBox chk_dropbox;
        private CheckBox chk_winrar;
        private CheckBox chk_adobereader;
        private TextBox txt_disco;
        private TextBox txt_memoriaran;
    }
}