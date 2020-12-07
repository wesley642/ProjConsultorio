namespace ProjConsultorio
{
    partial class FormConsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBConsultorioConsulta = new ProjConsultorio.DBConsultorioConsulta();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioDataMedicoSelect = new ProjConsultorio.DbConsultorioDataMedicoSelect();
            this.txtPaciente = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioDataSet1 = new ProjConsultorio.DbConsultorioDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataHora = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiagonostico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.dbConsultorioEspecialidadeSelect = new ProjConsultorio.DbConsultorioEspecialidadeSelect();
            this.especialidadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadsTableAdapter = new ProjConsultorio.DbConsultorioEspecialidadeSelectTableAdapters.EspecialidadsTableAdapter();
            this.dbConsultorioEspecialidadeSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new ProjConsultorio.DbConsultorioDataMedicoSelectTableAdapters.MedicosTableAdapter();
            this.especialidadsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new ProjConsultorio.DbConsultorioDataSet1TableAdapters.PacientesTableAdapter();
            this.consultasTableAdapter = new ProjConsultorio.DBConsultorioConsultaTableAdapters.ConsultasTableAdapter();
            this.dgConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBConsultorioConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataMedicoSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioEspecialidadeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioEspecialidadeSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = global::ProjConsultorio.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.Location = new System.Drawing.Point(111, 13);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(44, 40);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::ProjConsultorio.Properties.Resources.UPDATEicon;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(61, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(44, 40);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::ProjConsultorio.Properties.Resources.Add_User_80_icon_icons_com_57380;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.Location = new System.Drawing.Point(11, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(44, 40);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.dBConsultorioConsulta;
            // 
            // dBConsultorioConsulta
            // 
            this.dBConsultorioConsulta.DataSetName = "DBConsultorioConsulta";
            this.dBConsultorioConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Medico:";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(84, 17);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            this.txtIdMedico.Size = new System.Drawing.Size(44, 20);
            this.txtIdMedico.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID:";
            // 
            // txtMedico
            // 
            this.txtMedico.DataSource = this.medicosBindingSource;
            this.txtMedico.DisplayMember = "Nome";
            this.txtMedico.FormattingEnabled = true;
            this.txtMedico.ItemHeight = 13;
            this.txtMedico.Location = new System.Drawing.Point(84, 42);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(184, 21);
            this.txtMedico.TabIndex = 0;
            this.txtMedico.ValueMember = "IdMedico";
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.dbConsultorioDataMedicoSelect;
            // 
            // dbConsultorioDataMedicoSelect
            // 
            this.dbConsultorioDataMedicoSelect.DataSetName = "DbConsultorioDataMedicoSelect";
            this.dbConsultorioDataMedicoSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPaciente
            // 
            this.txtPaciente.DataSource = this.pacientesBindingSource;
            this.txtPaciente.DisplayMember = "Nome";
            this.txtPaciente.FormattingEnabled = true;
            this.txtPaciente.Location = new System.Drawing.Point(84, 95);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(184, 21);
            this.txtPaciente.TabIndex = 2;
            this.txtPaciente.ValueMember = "IdPaciente";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.dbConsultorioDataSet1;
            // 
            // dbConsultorioDataSet1
            // 
            this.dbConsultorioDataSet1.DataSetName = "DbConsultorioDataSet1";
            this.dbConsultorioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Data/Hora:";
            // 
            // txtDataHora
            // 
            this.txtDataHora.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtDataHora.Location = new System.Drawing.Point(403, 43);
            this.txtDataHora.Mask = "00/00/0000 90:00";
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(121, 20);
            this.txtDataHora.TabIndex = 3;
            this.txtDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(403, 100);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Valor R$:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Exame:";
            // 
            // txtDiagonostico
            // 
            this.txtDiagonostico.Location = new System.Drawing.Point(84, 204);
            this.txtDiagonostico.Multiline = true;
            this.txtDiagonostico.Name = "txtDiagonostico";
            this.txtDiagonostico.Size = new System.Drawing.Size(441, 124);
            this.txtDiagonostico.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Diagnostico:";
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(84, 144);
            this.txtExame.Multiline = true;
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(440, 38);
            this.txtExame.TabIndex = 5;
            // 
            // dbConsultorioEspecialidadeSelect
            // 
            this.dbConsultorioEspecialidadeSelect.DataSetName = "DbConsultorioEspecialidadeSelect";
            this.dbConsultorioEspecialidadeSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadsBindingSource
            // 
            this.especialidadsBindingSource.DataMember = "Especialidads";
            this.especialidadsBindingSource.DataSource = this.dbConsultorioEspecialidadeSelect;
            // 
            // especialidadsTableAdapter
            // 
            this.especialidadsTableAdapter.ClearBeforeFill = true;
            // 
            // dbConsultorioEspecialidadeSelectBindingSource
            // 
            this.dbConsultorioEspecialidadeSelectBindingSource.DataSource = this.dbConsultorioEspecialidadeSelect;
            this.dbConsultorioEspecialidadeSelectBindingSource.Position = 0;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // especialidadsBindingSource1
            // 
            this.especialidadsBindingSource1.DataMember = "Especialidads";
            this.especialidadsBindingSource1.DataSource = this.dbConsultorioEspecialidadeSelectBindingSource;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // dgConsulta
            // 
            this.dgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsulta.Location = new System.Drawing.Point(15, 393);
            this.dgConsulta.Name = "dgConsulta";
            this.dgConsulta.Size = new System.Drawing.Size(535, 224);
            this.dgConsulta.TabIndex = 88;
            this.dgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsulta_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataHora);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtExame);
            this.groupBox1.Controls.Add(this.txtIdMedico);
            this.groupBox1.Controls.Add(this.txtDiagonostico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMedico);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 338);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Location = new System.Drawing.Point(15, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 59);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBConsultorioConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataMedicoSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioEspecialidadeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioEspecialidadeSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtMedico;
        private System.Windows.Forms.ComboBox txtPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDataHora;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiagonostico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExame;
        private DbConsultorioEspecialidadeSelect dbConsultorioEspecialidadeSelect;
        private System.Windows.Forms.BindingSource especialidadsBindingSource;
        private DbConsultorioEspecialidadeSelectTableAdapters.EspecialidadsTableAdapter especialidadsTableAdapter;
        private System.Windows.Forms.BindingSource dbConsultorioEspecialidadeSelectBindingSource;
        private DbConsultorioDataMedicoSelect dbConsultorioDataMedicoSelect;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private DbConsultorioDataMedicoSelectTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.BindingSource especialidadsBindingSource1;
        private DbConsultorioDataSet1 dbConsultorioDataSet1;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private DbConsultorioDataSet1TableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private DBConsultorioConsulta dBConsultorioConsulta;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private DBConsultorioConsultaTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private System.Windows.Forms.DataGridView dgConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}