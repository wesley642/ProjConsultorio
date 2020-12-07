namespace ProjConsultorio
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.btnSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEspecialidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManutencaoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblagora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbljundiai = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.mnStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // mnStrip
            // 
            this.mnStrip.BackColor = System.Drawing.SystemColors.Control;
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSistema,
            this.btnSair});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(1142, 24);
            this.mnStrip.TabIndex = 0;
            this.mnStrip.Text = "menuStrip1";
            // 
            // btnSistema
            // 
            this.btnSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastro,
            this.btnManutencao});
            this.btnSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSistema.Image")));
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(76, 20);
            this.btnSistema.Text = "Sistema";
            // 
            // btnCadastro
            // 
            this.btnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPaciente,
            this.btnMedico,
            this.btnConsulta,
            this.btnEspecialidade});
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(141, 22);
            this.btnCadastro.Text = "Cadastro";
            // 
            // btnPaciente
            // 
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(145, 22);
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(145, 22);
            this.btnMedico.Text = "Medico";
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(145, 22);
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEspecialidade
            // 
            this.btnEspecialidade.Image = ((System.Drawing.Image)(resources.GetObject("btnEspecialidade.Image")));
            this.btnEspecialidade.Name = "btnEspecialidade";
            this.btnEspecialidade.Size = new System.Drawing.Size(145, 22);
            this.btnEspecialidade.Text = "Especialidade";
            this.btnEspecialidade.Click += new System.EventHandler(this.btnEspecialidade_Click);
            // 
            // btnManutencao
            // 
            this.btnManutencao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManutencaoUsuario});
            this.btnManutencao.Image = ((System.Drawing.Image)(resources.GetObject("btnManutencao.Image")));
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(141, 22);
            this.btnManutencao.Text = "Manutenção";
            // 
            // btnManutencaoUsuario
            // 
            this.btnManutencaoUsuario.Image = global::ProjConsultorio.Properties.Resources.Add_User_80_icon_icons_com_57380;
            this.btnManutencaoUsuario.Name = "btnManutencaoUsuario";
            this.btnManutencaoUsuario.Size = new System.Drawing.Size(114, 22);
            this.btnManutencaoUsuario.Text = "Usuario";
            this.btnManutencaoUsuario.Click += new System.EventHandler(this.btnManutencaoUsuario_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 20);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgConsultas
            // 
            this.dgConsultas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.GridColor = System.Drawing.SystemColors.Control;
            this.dgConsultas.Location = new System.Drawing.Point(302, 173);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsultas.RowHeadersVisible = false;
            this.dgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgConsultas.Size = new System.Drawing.Size(418, 157);
            this.dgConsultas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultas Agendadas Para Hoje:";
            // 
            // lblagora
            // 
            this.lblagora.AutoSize = true;
            this.lblagora.BackColor = System.Drawing.Color.Transparent;
            this.lblagora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblagora.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblagora.Location = new System.Drawing.Point(605, 110);
            this.lblagora.Name = "lblagora";
            this.lblagora.Size = new System.Drawing.Size(89, 30);
            this.lblagora.TabIndex = 4;
            this.lblagora.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbljundiai
            // 
            this.lbljundiai.AutoSize = true;
            this.lbljundiai.BackColor = System.Drawing.Color.Transparent;
            this.lbljundiai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbljundiai.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljundiai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbljundiai.Location = new System.Drawing.Point(319, 110);
            this.lbljundiai.Name = "lbljundiai";
            this.lbljundiai.Size = new System.Drawing.Size(142, 30);
            this.lbljundiai.TabIndex = 5;
            this.lbljundiai.Text = "Jundiaí-SP,";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldata.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldata.Location = new System.Drawing.Point(454, 110);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(89, 30);
            this.lbldata.TabIndex = 6;
            this.lbldata.Text = "label2";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1142, 636);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lbljundiai);
            this.Controls.Add(this.lblagora);
            this.Controls.Add(this.dgConsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrip;
            this.MaximumSize = new System.Drawing.Size(1158, 675);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStripMenuItem btnSistema;
        private System.Windows.Forms.ToolStripMenuItem btnCadastro;
        private System.Windows.Forms.ToolStripMenuItem btnPaciente;
        private System.Windows.Forms.ToolStripMenuItem btnMedico;
        private System.Windows.Forms.ToolStripMenuItem btnConsulta;
        private System.Windows.Forms.ToolStripMenuItem btnEspecialidade;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnManutencao;
        private System.Windows.Forms.ToolStripMenuItem btnManutencaoUsuario;
        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblagora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbljundiai;
        private System.Windows.Forms.Label lbldata;
    }
}

