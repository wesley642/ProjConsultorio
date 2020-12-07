using ProjConsultorio.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjConsultorio
{
    public partial class FormManutUsuario : Form
    {
        public FormManutUsuario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string segundoNome = txtSegundoNome.Text;
                string sobreNome = txtSobreNome.Text;

                string usuario;


                if (segundoNome == "")
                {
                    usuario = nome + "." + sobreNome;
                    txtUsuario.Text = usuario;
                }
                else
                {
                    string subUsuario = segundoNome.Substring(0, 1);
                    usuario = nome + "." + subUsuario + sobreNome;
                    txtUsuario.Text = usuario;
                }




                var tbx = new Contexto();
                var objeto = tbx.ObjetoManutUser.Where(a => a.Usuario == usuario).FirstOrDefault();

                if (objeto == null)
                {
                    if (txtNome.Text == "" || txtSobreNome.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtSenha.Text.Length < 5)
                        {
                            MessageBox.Show("Senha deve conter mais do que 5 caracteres!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {

                            using (var tb = new Contexto())
                            {
                                tb.ObjetoManutUser.Add(new ManutUser { Usuario = usuario, Nome = txtNome.Text, SegundoNome = txtSegundoNome.Text, SobreNome = txtSobreNome.Text, Senha = txtSenha.Text });
                                tb.SaveChanges();
                            }
                            //Atualizar o grid

                            MessageBox.Show("Incluido com súcesso", "Inclusão");
                            AtualizarGrid();
                            LimparCampos();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Usuario já cadastrado!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSobreNome_Leave(object sender, EventArgs e)
        {
            if (AlterarVef == 0)
            {
                string nome = txtNome.Text;
                string segundoNome = txtSegundoNome.Text;
                string sobreNome = txtSobreNome.Text;

                string usuario;

                if (segundoNome == "")
                {
                    usuario = nome + "." + sobreNome;
                    txtUsuario.Text = usuario;
                }
                else
                {
                    string subUsuario = segundoNome.Substring(0, 1);
                    usuario = nome + "." + subUsuario + sobreNome;
                    txtUsuario.Text = usuario;
                }

            }
        }

        private void FormManutUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBCONSUTORIODATAGRID.ManutUsers'. Você pode movê-la ou removê-la conforme necessário.
            this.manutUsersTableAdapter.Fill(this.dBCONSUTORIODATAGRID.ManutUsers);
            AtualizarGrid();


            //var tb = new Contexto();
            //var result = from Medico in tb.ObjetoMedico
            //             join Especialidad in tb.ObjetoEspecialidade
            //             on Medico.IdMedico equals Especialidad.IdEspecialidade
            //             select new { Medico.IdMedico, Medico.Nome, Especialidad.IdEspecialidade, Especialidad.Especialidade};

            //try
            //{
            //    gridzera.DataSource = result.ToList();
            //}
            //catch
            //{
            //    MessageBox.Show("cuzin");
            //}


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    if (txtID.Text == "")
                    {
                        MessageBox.Show("Preencha os campos, para efetuar uma atualização!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var objeto = tb.ObjetoManutUser.Find(Convert.ToInt32(txtID.Text));
                        objeto.Nome = txtNome.Text;
                        objeto.SegundoNome = txtSegundoNome.Text;
                        objeto.SobreNome = txtSobreNome.Text;
                        objeto.Usuario = txtUsuario.Text;
                        objeto.Senha = txtSenha.Text;

                        string VerficaUsuario = txtUsuario.Text;



                        var objeto2 = tb.ObjetoManutUser.Where(a => a.Usuario == VerficaUsuario).FirstOrDefault();

                        if (txtUsuario.ReadOnly == false)
                        {

                            if (objeto2 == null)
                            {
                                tb.Entry(objeto).State = EntityState.Modified;
                                tb.SaveChanges();
                                MessageBox.Show("Alterado com Sucesso", "Alteração");
                                AlterarVef = 0;
                                txtUsuario.ReadOnly = true;
                                AtualizarGrid();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Usuario já existe!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {                 
                            
                            tb.Entry(objeto).State = EntityState.Modified;
                            tb.SaveChanges();
                            MessageBox.Show("Alterado com Sucesso", "Alteração");
                            AlterarVef = 0;
                            txtUsuario.ReadOnly = true;
                            AtualizarGrid();
                            LimparCampos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        public void AtualizarGrid()
        {
            using (var tb = new Contexto())
            {
                dgUsuario.DataSource = null;
                dgUsuario.DataSource = tb.ObjetoManutUser.ToList();
            }
        }

        public void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtSegundoNome.Clear();
            txtSobreNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        int AlterarVef = 0;

        private void dgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarVef = 1;

            txtID.Text = dgUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dgUsuario.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgUsuario.CurrentRow.Cells[2].Value.ToString();
            txtSegundoNome.Text = dgUsuario.CurrentRow.Cells[3].Value.ToString();
            txtSobreNome.Text = dgUsuario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgUsuario.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtUsuario_DoubleClick(object sender, EventArgs e)
        {
            FormLoginADM VFadm = new FormLoginADM();
            VFadm.ShowDialog();

            if (VFadm.Ladm == 1)
            {
                txtUsuario.ReadOnly = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                using (var tb = new Contexto())
                {
                    if (txtID.Text == "")
                    {
                        MessageBox.Show("Preencha os campos, para efetuar uma atualização!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var objeto = tb.ObjetoManutUser.Find(Convert.ToInt32(txtID.Text));
                        tb.ObjetoManutUser.Remove(objeto);
                        tb.SaveChanges();
                        MessageBox.Show("Excluido com Sucesso", "Exclusão");
                        LimparCampos();
                        AtualizarGrid();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
