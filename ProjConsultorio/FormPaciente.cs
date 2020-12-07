using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjConsultorio
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }


        public void LimparCampos()
        {
            txtIdPaciente.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtCPF.Clear();
            txtNumCartao.Clear();
            txtNome.Focus();
            txtConvenio.SelectedIndex = -1;
            txtPlano.SelectedIndex = -1;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtCEP.Text == "00000-000")
                        {
                            MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (txtNumCartao.Text == "")
                            {
                                MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                tb.ObjetoPaciente.Add(new Paciente { Nome = txtNome.Text, Telefone = txtTelefone.Text, CPF = txtCPF.Text, Convenio = txtConvenio.Text, Plano = txtPlano.Text, NumCartao = txtNumCartao.Text, Rua = txtRua.Text, CEP = txtCEP.Text, Bairro = txtBairro.Text, Cidade = txtCidade.Text, Estado = txtEstado.Text });
                                tb.SaveChanges();
                                LimparCampos();
                                AtualizarGrid();
                                MessageBox.Show("Incluido com súcesso", "Inclusão");
                            }
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
                gridPaciente.DataSource = null;
                gridPaciente.DataSource = tb.ObjetoPaciente.ToList();
            }
        }

        private void LocalizaCEP()
        {
            using (var ws = new Correios.AtendeClienteClient())
            {

                try
                {
                    var resultado = ws.consultaCEP(txtCEP.Text);
                    txtEstado.Text = resultado.uf;
                    txtCidade.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    txtRua.Text = resultado.end;
                }
                catch (Exception)
                {
                    MessageBox.Show("CEP Inválido!", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Clear();
                }
            }
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioPaciente.Pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pacientesTableAdapter.Fill(this.dbConsultorioPaciente.Pacientes);
            AtualizarGrid();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            LocalizaCEP();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {

                try
                {

                    if (txtIdPaciente.Text == "")
                    {
                        MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string NumCartaoVef;
                        NumCartaoVef = txtNumCartao.Text;




                        var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtIdPaciente.Text));
                        objeto.Nome = txtNome.Text;
                        objeto.CEP = txtCEP.Text;
                        objeto.Rua = txtRua.Text;
                        objeto.Bairro = txtBairro.Text;
                        objeto.Estado = txtEstado.Text;
                        objeto.Cidade = txtCidade.Text;
                        objeto.Telefone = txtTelefone.Text;
                        objeto.CPF = txtCPF.Text;
                        objeto.Convenio = txtConvenio.Text;
                        objeto.Plano = txtPlano.Text;
                        objeto.NumCartao = txtNumCartao.Text;

                        tb.Entry(objeto).State = EntityState.Modified;
                        tb.SaveChanges();
                        MessageBox.Show("Alteração Concluida", "Alteração");
                        LimparCampos();
                        AtualizarGrid();


                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {

                using (var tb = new Contexto())
                {



                    int PacienteId = Convert.ToInt32(txtIdPaciente.Text);

                    var objetox = tb.ObjetoConsulta.Where(a => a.IdPaciente == PacienteId).FirstOrDefault();


                    if (objetox != null)
                    {
                        MessageBox.Show("Medico está cadastrado em alguma consulta!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtIdPaciente.Text == "")
                        {
                            MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            var objeto = tb.ObjetoPaciente.Find(Convert.ToInt32(txtIdPaciente.Text));
                            tb.ObjetoPaciente.Remove(objeto);
                            tb.SaveChanges();
                            MessageBox.Show("Excluido com Sucesso", "Exclusão");
                            LimparCampos();
                            AtualizarGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPaciente.Text = gridPaciente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridPaciente.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = gridPaciente.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = gridPaciente.CurrentRow.Cells[3].Value.ToString();
            txtConvenio.Text = gridPaciente.CurrentRow.Cells[4].Value.ToString();
            txtPlano.Text = gridPaciente.CurrentRow.Cells[5].Value.ToString();
            txtNumCartao.Text = gridPaciente.CurrentRow.Cells[6].Value.ToString();
            txtCEP.Text = gridPaciente.CurrentRow.Cells[7].Value.ToString();
            txtRua.Text = gridPaciente.CurrentRow.Cells[8].Value.ToString();
            txtBairro.Text = gridPaciente.CurrentRow.Cells[9].Value.ToString();
            txtCidade.Text = gridPaciente.CurrentRow.Cells[10].Value.ToString();
            txtEstado.Text = gridPaciente.CurrentRow.Cells[11].Value.ToString();
        }

        private void txtNumCartao_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
