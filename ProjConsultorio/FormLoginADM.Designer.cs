namespace ProjConsultorio
{
    partial class FormLoginADM
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
            this.txtUsuarioADM = new System.Windows.Forms.TextBox();
            this.txtSenhaADM = new System.Windows.Forms.TextBox();
            this.btnLoginADM = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuarioADM
            // 
            this.txtUsuarioADM.Location = new System.Drawing.Point(71, 27);
            this.txtUsuarioADM.Name = "txtUsuarioADM";
            this.txtUsuarioADM.Size = new System.Drawing.Size(156, 20);
            this.txtUsuarioADM.TabIndex = 0;
            this.txtUsuarioADM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioADM_KeyDown);
            // 
            // txtSenhaADM
            // 
            this.txtSenhaADM.Location = new System.Drawing.Point(71, 53);
            this.txtSenhaADM.Name = "txtSenhaADM";
            this.txtSenhaADM.PasswordChar = '*';
            this.txtSenhaADM.Size = new System.Drawing.Size(156, 20);
            this.txtSenhaADM.TabIndex = 1;
            this.txtSenhaADM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenhaADM_KeyDown);
            // 
            // btnLoginADM
            // 
            this.btnLoginADM.Location = new System.Drawing.Point(71, 93);
            this.btnLoginADM.Name = "btnLoginADM";
            this.btnLoginADM.Size = new System.Drawing.Size(75, 23);
            this.btnLoginADM.TabIndex = 2;
            this.btnLoginADM.Text = "Logar";
            this.btnLoginADM.UseVisualStyleBackColor = true;
            this.btnLoginADM.Click += new System.EventHandler(this.btnLoginADM_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // FormLoginADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(281, 133);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLoginADM);
            this.Controls.Add(this.txtSenhaADM);
            this.Controls.Add(this.txtUsuarioADM);
            this.Name = "FormLoginADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ADM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioADM;
        private System.Windows.Forms.TextBox txtSenhaADM;
        private System.Windows.Forms.Button btnLoginADM;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}