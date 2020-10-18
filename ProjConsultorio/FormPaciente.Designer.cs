namespace ProjConsultorio
{
    partial class FormPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaciente));
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.txtNumCartao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlano = new System.Windows.Forms.TextBox();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPaciente
            // 
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Location = new System.Drawing.Point(43, 198);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.Size = new System.Drawing.Size(503, 255);
            this.gridPaciente.TabIndex = 39;
            // 
            // txtNumCartao
            // 
            this.txtNumCartao.Location = new System.Drawing.Point(379, 123);
            this.txtNumCartao.Name = "txtNumCartao";
            this.txtNumCartao.Size = new System.Drawing.Size(166, 20);
            this.txtNumCartao.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Numero do Cartão:";
            // 
            // txtPlano
            // 
            this.txtPlano.Location = new System.Drawing.Point(379, 97);
            this.txtPlano.Name = "txtPlano";
            this.txtPlano.Size = new System.Drawing.Size(88, 20);
            this.txtPlano.TabIndex = 5;
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(379, 72);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(166, 20);
            this.txtConvenio.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 64);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(167, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(443, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Location = new System.Drawing.Point(102, 91);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(129, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtCPF
            // 
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Location = new System.Drawing.Point(102, 123);
            this.txtCPF.Mask = "000-000-000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(129, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Plano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Convênio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome:";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(102, 12);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.ReadOnly = true;
            this.txtIdPaciente.Size = new System.Drawing.Size(50, 20);
            this.txtIdPaciente.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(379, 157);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(254, 157);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(102, 157);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 479);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gridPaciente);
            this.Controls.Add(this.txtNumCartao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlano);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPaciente";
            this.Text = "Cadastro de Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPaciente;
        private System.Windows.Forms.TextBox txtNumCartao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlano;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
    }
}