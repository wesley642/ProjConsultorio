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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataHora = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiagonostico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExame = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(357, 353);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(227, 353);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(101, 353);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // gridConsulta
            // 
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsulta.Location = new System.Drawing.Point(25, 400);
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(525, 224);
            this.gridConsulta.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Medico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Especialidade:";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(101, 23);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(44, 20);
            this.txtIdMedico.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID:";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Items.AddRange(new object[] {
            "wesley",
            "lucas",
            "pedro",
            "vini"});
            this.cbEspecialidade.Location = new System.Drawing.Point(101, 75);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(184, 21);
            this.cbEspecialidade.TabIndex = 1;
            // 
            // cbMedico
            // 
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.ItemHeight = 13;
            this.cbMedico.Location = new System.Drawing.Point(101, 48);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(184, 21);
            this.cbMedico.TabIndex = 0;
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(101, 105);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(184, 21);
            this.cbPaciente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Data/Hora:";
            // 
            // txtDataHora
            // 
            this.txtDataHora.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtDataHora.Location = new System.Drawing.Point(420, 49);
            this.txtDataHora.Mask = "00/00/0000 90:00";
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(126, 20);
            this.txtDataHora.TabIndex = 3;
            this.txtDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(420, 106);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(126, 20);
            this.txtValor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Exame:";
            // 
            // txtDiagonostico
            // 
            this.txtDiagonostico.Location = new System.Drawing.Point(101, 210);
            this.txtDiagonostico.Multiline = true;
            this.txtDiagonostico.Name = "txtDiagonostico";
            this.txtDiagonostico.Size = new System.Drawing.Size(446, 124);
            this.txtDiagonostico.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Diagnostico:";
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(101, 150);
            this.txtExame.Multiline = true;
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(445, 38);
            this.txtExame.TabIndex = 5;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 643);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.txtDiagonostico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEspecialidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.Text = "Cadastro de Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView gridConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDataHora;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiagonostico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExame;
    }
}