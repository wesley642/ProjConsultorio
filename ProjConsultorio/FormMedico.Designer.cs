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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedico));
            this.cmEspecialidade = new System.Windows.Forms.ComboBox();
            this.gridMedico = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // cmEspecialidade
            // 
            this.cmEspecialidade.FormattingEnabled = true;
            this.cmEspecialidade.ItemHeight = 13;
            this.cmEspecialidade.Location = new System.Drawing.Point(114, 65);
            this.cmEspecialidade.Name = "cmEspecialidade";
            this.cmEspecialidade.Size = new System.Drawing.Size(184, 21);
            this.cmEspecialidade.TabIndex = 0;
            // 
            // gridMedico
            // 
            this.gridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedico.Location = new System.Drawing.Point(35, 183);
            this.gridMedico.Name = "gridMedico";
            this.gridMedico.Size = new System.Drawing.Size(503, 224);
            this.gridMedico.TabIndex = 56;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Location = new System.Drawing.Point(418, 38);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(120, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Especialidade:";
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(114, 13);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.ReadOnly = true;
            this.txtIdMedico.Size = new System.Drawing.Size(44, 20);
            this.txtIdMedico.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(114, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(424, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Location = new System.Drawing.Point(418, 65);
            this.txtCPF.Mask = "000-000-000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(120, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "CPF:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(369, 138);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(239, 138);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(113, 138);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 431);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.gridMedico);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmEspecialidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedico";
            this.Text = "Cadastro de Medico";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmEspecialidade;
        private System.Windows.Forms.DataGridView gridMedico;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
    }
}