namespace ProjConsultorio
{
    partial class FormManutUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutUsuario));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSegundoNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobreNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBCONSUTORIODATAGRID = new ProjConsultorio.DBCONSUTORIODATAGRID();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dbConsultorioDataSet = new ProjConsultorio.DbConsultorioDataSet();
            this.dbConsultorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manutUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manutUsersTableAdapter = new ProjConsultorio.DBCONSUTORIODATAGRIDTableAdapters.ManutUsersTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCONSUTORIODATAGRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutUsersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(107, 16);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(51, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSegundoNome
            // 
            this.txtSegundoNome.Location = new System.Drawing.Point(107, 68);
            this.txtSegundoNome.Name = "txtSegundoNome";
            this.txtSegundoNome.Size = new System.Drawing.Size(199, 20);
            this.txtSegundoNome.TabIndex = 2;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(107, 94);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(199, 20);
            this.txtSobreNome.TabIndex = 3;
            this.txtSobreNome.Leave += new System.EventHandler(this.txtSobreNome_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 120);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtUsuario.TabIndex = 42;
            this.txtUsuario.DoubleClick += new System.EventHandler(this.txtUsuario_DoubleClick);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(107, 146);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(119, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Segundo Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sobre Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha:";
            // 
            // dgUsuario
            // 
            this.dgUsuario.AllowUserToAddRows = false;
            this.dgUsuario.AllowUserToDeleteRows = false;
            this.dgUsuario.AutoGenerateColumns = false;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Usuario,
            this.Nome,
            this.SegundoNome,
            this.SobreNome,
            this.Senha});
            this.dgUsuario.DataSource = this.dBCONSUTORIODATAGRID;
            this.dgUsuario.Location = new System.Drawing.Point(41, 251);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.ReadOnly = true;
            this.dgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuario.Size = new System.Drawing.Size(403, 150);
            this.dgUsuario.TabIndex = 12;
            this.dgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuario_CellClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "UsuarioID";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // SegundoNome
            // 
            this.SegundoNome.DataPropertyName = "SegundoNome";
            this.SegundoNome.HeaderText = "SegundoNome";
            this.SegundoNome.Name = "SegundoNome";
            this.SegundoNome.ReadOnly = true;
            // 
            // SobreNome
            // 
            this.SobreNome.DataPropertyName = "SobreNome";
            this.SobreNome.HeaderText = "SobreNome";
            this.SobreNome.Name = "SobreNome";
            this.SobreNome.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // dBCONSUTORIODATAGRID
            // 
            this.dBCONSUTORIODATAGRID.DataSetName = "DBCONSUTORIODATAGRID";
            this.dBCONSUTORIODATAGRID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::ProjConsultorio.Properties.Resources.Add_User_80_icon_icons_com_57380;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.Location = new System.Drawing.Point(14, 16);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(44, 40);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::ProjConsultorio.Properties.Resources.UPDATEicon;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(64, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(44, 40);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ProjConsultorio.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(114, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(44, 40);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            // manutUsersBindingSource
            // 
            this.manutUsersBindingSource.DataMember = "ManutUsers";
            this.manutUsersBindingSource.DataSource = this.dBCONSUTORIODATAGRID;
            // 
            // manutUsersTableAdapter
            // 
            this.manutUsersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtSegundoNome);
            this.groupBox1.Controls.Add(this.txtSobreNome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(41, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 177);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Location = new System.Drawing.Point(41, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 65);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "F1 - Cadastrar, F2 - Update, F3 - Deletar";
            // 
            // FormManutUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(486, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManutUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FormManutUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCONSUTORIODATAGRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConsultorioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutUsersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSegundoNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.BindingSource dbConsultorioDataSetBindingSource;
        private DbConsultorioDataSet dbConsultorioDataSet;
        private DBCONSUTORIODATAGRID dBCONSUTORIODATAGRID;
        private System.Windows.Forms.BindingSource manutUsersBindingSource;
        private DBCONSUTORIODATAGRIDTableAdapters.ManutUsersTableAdapter manutUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobreNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}