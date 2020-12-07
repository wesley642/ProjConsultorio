using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace ProjConsultorio
{
    public partial class FormLoginADM : Form
    {
        public FormLoginADM()
        {
            InitializeComponent();
        }

        public int Ladm { get; set; }



        public void LimparCampos()
        {
            txtUsuarioADM.Clear();
            txtSenhaADM.Clear();
        }

        public void LoginEnter()
        {

            //if (xUsuario == "adm" && xSenha == "@dmin123")
            //{
            //    Ladm = 1;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario ou Senha Errada!");
            //}


            string xUsuario = txtUsuarioADM.Text;
            string xSenha = txtSenhaADM.Text;


            using (var tb = new Contexto())
            {
                var objeto = tb.ObjetoManutUser.Where(a => a.Usuario == xUsuario).FirstOrDefault();

                if (objeto != null)
                {
                    if (objeto.Usuario == "adm")
                    {
                        
                        if (objeto.Usuario == xUsuario )
                        {

                            if (objeto.Senha == xSenha)
                            {
                                Ladm = 1;
                                this.Close();
                            }
                            else
                            {                                
                                MessageBox.Show("Senha ou Usuario errado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LimparCampos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Senha ou Usuario errado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimparCampos();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Senha ou Usuario errado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparCampos();
                    }

                }
                else
                {
                    MessageBox.Show("Senha ou Usuario errado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }

            }

        }


        private void btnLoginADM_Click(object sender, EventArgs e)
        {
            LoginEnter();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenhaADM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEnter();
            }
        }

        private void txtUsuarioADM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEnter();
            }
        }
    }
}
