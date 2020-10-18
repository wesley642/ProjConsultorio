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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.btnSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEspecialidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mnStrip.Size = new System.Drawing.Size(592, 24);
            this.mnStrip.TabIndex = 0;
            this.mnStrip.Text = "menuStrip1";
            // 
            // btnSistema
            // 
            this.btnSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastro});
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
            this.btnCadastro.Size = new System.Drawing.Size(180, 22);
            this.btnCadastro.Text = "Cadastro";
            // 
            // btnPaciente
            // 
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(180, 22);
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(180, 22);
            this.btnMedico.Text = "Medico";
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(180, 22);
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEspecialidade
            // 
            this.btnEspecialidade.Image = ((System.Drawing.Image)(resources.GetObject("btnEspecialidade.Image")));
            this.btnEspecialidade.Name = "btnEspecialidade";
            this.btnEspecialidade.Size = new System.Drawing.Size(180, 22);
            this.btnEspecialidade.Text = "Especialidade";
            this.btnEspecialidade.Click += new System.EventHandler(this.btnEspecialidade_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 20);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 337);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrip;
            this.MaximumSize = new System.Drawing.Size(608, 400);
            this.MinimumSize = new System.Drawing.Size(608, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

