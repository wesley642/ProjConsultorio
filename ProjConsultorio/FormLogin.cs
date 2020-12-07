using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProjConsultorio.Classes;

namespace ProjConsultorio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        public int VerficarAdminUsuario;

        public void LoginEvento()
        {
            string xUsuario = txtUsuario.Text;
            string xSenha = txtSenha.Text;

            using (var tb = new Contexto())
            {

                try
                {
                    
                    var objeto = tb.ObjetoManutUser.Where(a => a.Usuario == xUsuario).FirstOrDefault();

                    if (objeto != null )
                    {

                        if (objeto.Usuario == xUsuario)
                        {
                            if (objeto.Senha == xSenha)
                            {

                                if (objeto.Usuario == "adm")
                                {
                                    if (objeto.Senha == xSenha)
                                    {
                                        VerficarAdminUsuario = 1;
                                    }
                                }

                                this.Hide();
                                FormPrincipal f = new FormPrincipal();
                                f.Closed += (s, args) => this.Close();
                                if (VerficarAdminUsuario == 1)
                                {
                                    f.VerificarAdminLoginPrincipal = 1;
                                }
                                f.Show();

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginEvento();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEvento();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEvento();
            }
        }
    }
}
