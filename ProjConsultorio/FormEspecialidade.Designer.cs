namespace ProjConsultorio
{
    partial class FormEspecialidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspecialidade));
            this.gridEspecialidade = new System.Windows.Forms.DataGridView();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecialidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEspecialidade
            // 
            this.gridEspecialidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEspecialidade.Location = new System.Drawing.Point(37, 121);
            this.gridEspecialidade.Name = "gridEspecialidade";
            this.gridEspecialidade.Size = new System.Drawing.Size(268, 200);
            this.gridEspecialidade.TabIndex = 44;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(117, 47);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(188, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(58, 20);
            this.txtNome.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Especialidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(38, 81);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(138, 81);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(230, 81);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // FormEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(338, 344);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gridEspecialidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEspecialidade";
            this.Text = "Cadastro de Especialidade";
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecialidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEspecialidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
    }
}