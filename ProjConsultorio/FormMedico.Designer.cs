namespace ProjConsultorio
{
    partial class FormMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedico));
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBConsultorioMedico = new ProjConsultorio.DBConsultorioMedico();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dbConsultorioDataSet = new ProjConsultorio.DbConsultorioDataSet();
            this.dbConsultorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConsultorioEspecialidadeSelect = new ProjConsultorio.DbConsultorioEspecialidadeSelect();
            this.especialidadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadsTableAdapter = new ProjConsultorio.DbConsultorioEspecialidadeSelectTableAdapters.EspecialidadsTableAdapter();
            this.txtEspecialidade = new System.Windows.Forms.ComboBox();
            this.medicosTableAdapter = new ProjConsultorio.DBConsultorioMedicoTableAdapters.MedicosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.DgMedico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBConsultorioMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioEspecialidadeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.dBConsultorioMedico;
            // 
            // dBConsultorioMedico
            // 
            this.dBConsultorioMedico.DataSetName = "DBConsultorioMedico";
            this.dBConsultorioMedico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Location = new System.Drawing.Point(372, 101);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(120, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Especialidade:";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(105, 76);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            this.txtIdMedico.Size = new System.Drawing.Size(44, 20);
            this.txtIdMedico.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // txtCPF
            // 
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Location = new System.Drawing.Point(372, 128);
            this.txtCPF.Mask = "000-000-000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(120, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "CPF:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletar.BackgroundImage")));
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.Location = new System.Drawing.Point(124, 14);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(44, 40);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::ProjConsultorio.Properties.Resources.UPDATEicon;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(74, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(44, 40);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEP.Location = new System.Drawing.Point(88, 152);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(127, 20);
            this.txtCEP.TabIndex = 60;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(372, 152);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(50, 20);
            this.txtEstado.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "Estado:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(371, 178);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(121, 20);
            this.txtBairro.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(86, 203);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 20);
            this.txtCidade.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Cidade:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(104, 177);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(192, 20);
            this.txtRua.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Rua/Avenida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "CEP :";
            // 
            // dbConsultorioDataSet
            // 
            this.dbConsultorioDataSet.DataSetName = "DbConsultorioDataSet";
            this.dbConsultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbConsultorioDataSetBindingSource
            // 
            this.dbConsultorioDataSetBindingSource.DataSource = this.dbConsultorioDataSet;
            this.dbConsultorioDataSetBindingSource.Position = 0;
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
            // txtEspecialidade
            // 
            this.txtEspecialidade.DataSource = this.especialidadsBindingSource;
            this.txtEspecialidade.DisplayMember = "Especialidade";
            this.txtEspecialidade.FormattingEnabled = true;
            this.txtEspecialidade.ItemHeight = 13;
            this.txtEspecialidade.Location = new System.Drawing.Point(105, 126);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(121, 21);
            this.txtEspecialidade.TabIndex = 0;
            this.txtEspecialidade.ValueMember = "IdEspecialidade";
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtIdMedico);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.txtEspecialidade);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(34, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 245);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.btnDeletar);
            this.groupBox2.Location = new System.Drawing.Point(34, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 62);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir.BackgroundImage = global::ProjConsultorio.Properties.Resources.Add_User_80_icon_icons_com_57380;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnInserir.Location = new System.Drawing.Point(24, 14);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(44, 40);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // DgMedico
            // 
            this.DgMedico.AllowUserToAddRows = false;
            this.DgMedico.AllowUserToDeleteRows = false;
            this.DgMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMedico.Location = new System.Drawing.Point(34, 255);
            this.DgMedico.Name = "DgMedico";
            this.DgMedico.ReadOnly = true;
            this.DgMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgMedico.Size = new System.Drawing.Size(521, 224);
            this.DgMedico.TabIndex = 70;
            this.DgMedico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgMedico_CellClick);
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 506);
            this.Controls.Add(this.DgMedico);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Medico";
            this.Load += new System.EventHandler(this.FormMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBConsultorioMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioEspecialidadeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private DbConsultorioDataSet dbConsultorioDataSet;
        private System.Windows.Forms.BindingSource dbConsultorioDataSetBindingSource;
        private DbConsultorioEspecialidadeSelect dbConsultorioEspecialidadeSelect;
        private System.Windows.Forms.BindingSource especialidadsBindingSource;
        private DbConsultorioEspecialidadeSelectTableAdapters.EspecialidadsTableAdapter especialidadsTableAdapter;
        private System.Windows.Forms.ComboBox txtEspecialidade;
        private DBConsultorioMedico dBConsultorioMedico;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private DBConsultorioMedicoTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView DgMedico;
    }
}