using ProjConsultorio.Correios;
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
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
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
                catch
                {
                    MessageBox.Show("CEP Inválido!", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Clear();
                }
            }
        }

        public void AtualizarGrid()
        {
            using (var tb = new Contexto())
            {


                var contexto = new Contexto();

                string NomeMedico;

                var result = from Medico in contexto.ObjetoMedico
                             join Especialidade in contexto.ObjetoEspecialidade
                             on Medico.IdEspecialidade equals Especialidade.IdEspecialidade

                             select new { Medico.IdMedico, Especialidade.Especialidade, NomeMedico = Medico.Nome, Medico.CEP, Medico.Rua, Medico.Bairro, Medico.Cidade, Medico.Estado, Medico.Telefone, Medico.CPF };

                DgMedico.DataSource = result.ToList();
            }
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
                            tb.ObjetoMedico.Add(new Medico { IdEspecialidade = Convert.ToInt32(txtEspecialidade.SelectedValue), Nome = txtNome.Text, Telefone = txtTelefone.Text, CPF = txtCPF.Text, CEP = txtCEP.Text, Rua = txtRua.Text, Bairro = txtBairro.Text, Cidade = txtCidade.Text, Estado = txtEstado.Text });
                            tb.SaveChanges();
                            LimparCampos();
                            MessageBox.Show("Incluido com Sucesso", "Inclusão");
                            AtualizarGrid();

                        }
                    }

                }
            }
            catch
            {

            }
        }

        public void LimparCampos()
        {
            txtIdMedico.Clear();
            txtNome.Clear();
            txtCEP.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtEspecialidade.SelectedIndex = -1;
        }

        private void FormMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBConsultorioMedico.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.dBConsultorioMedico.Medicos);
            AtualizarGrid();
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioEspecialidadeSelect.Especialidads'. Você pode movê-la ou removê-la conforme necessário.
            this.especialidadsTableAdapter.Fill(this.dbConsultorioEspecialidadeSelect.Especialidads);
            using (var tb = new Contexto())
            {

            }



            var contexto = new Contexto();

            string NomeMedico;

            var result = from Medico in contexto.ObjetoMedico
                         join Especialidade in contexto.ObjetoEspecialidade
                         on Medico.IdEspecialidade equals Especialidade.IdEspecialidade

                         select new { Medico.IdMedico, Especialidade.Especialidade, NomeMedico = Medico.Nome, Medico.CEP, Medico.Rua, Medico.Bairro, Medico.Cidade, Medico.Estado, Medico.Telefone, Medico.CPF };

            DgMedico.DataSource = result.ToList();



        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            LocalizaCEP();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {


                using (var tb = new Contexto())
                {


                    if (txtIdMedico.Text == "")
                    {
                        MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string TextoPesquisaNomeMedico;
                        TextoPesquisaNomeMedico = txtNome.Text;

                        // ver se ja existe no banco o nome do medico
                        var ObjetoPesquisaNomeMedico = tb.ObjetoMedico.Where(a => a.Nome == TextoPesquisaNomeMedico).FirstOrDefault();
                        // ver se ja existe no banco o nome do medico


                        var objeto = tb.ObjetoMedico.Find(Convert.ToInt32(txtIdMedico.Text));

                        //////////////////////////////////////EncontrarIdMedico  

                        int ResultadoPesquisaEspecialidade;
                        string TextoEspecialidade;
                        TextoEspecialidade = txtEspecialidade.Text;

                        var ObjetoPesquisaEspecialidade = tb.ObjetoEspecialidade.Where(a => a.Especialidade == TextoEspecialidade).FirstOrDefault();
                        ResultadoPesquisaEspecialidade = ObjetoPesquisaEspecialidade.IdEspecialidade;

                        objeto.IdEspecialidade = ResultadoPesquisaEspecialidade;

                        /////////////////////////////////////EncontrarIdMedico   

                        objeto.Nome = txtNome.Text;
                        objeto.Telefone = txtTelefone.Text;
                        objeto.CPF = txtCPF.Text;
                        objeto.CEP = txtCEP.Text;
                        objeto.Rua = txtRua.Text;
                        objeto.Bairro = txtBairro.Text;
                        objeto.Cidade = txtCidade.Text;
                        objeto.Estado = txtEstado.Text;

                        tb.Entry(objeto).State = EntityState.Modified;
                        tb.SaveChanges();
                        MessageBox.Show("Alterado com Sucesso", "Alteração");
                        AtualizarGrid();
                        LimparCampos();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro!");

            }


        }



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {

                    int MedicoId = Convert.ToInt32(txtIdMedico.Text);

                    var objetox = tb.ObjetoConsulta.Where(a => a.IdMedico == MedicoId ).FirstOrDefault();


                    if (objetox != null)
                    {
                        MessageBox.Show("Medico está cadastrado em alguma consulta!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtIdMedico.Text != "")
                        {
                            var objeto = tb.ObjetoMedico.Find(Convert.ToInt32(txtIdMedico.Text));
                            tb.ObjetoMedico.Remove(objeto);
                            tb.SaveChanges();
                            MessageBox.Show("Medico excluido com Sucesso", "Exclusão");
                            LimparCampos();
                            AtualizarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }


                }
            }
            catch
            {

                MessageBox.Show("Não pode Excluir!");

            }
        }

        private void DgMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = DgMedico.CurrentRow.Cells[0].Value.ToString();
            txtEspecialidade.Text = DgMedico.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = DgMedico.CurrentRow.Cells[2].Value.ToString();
            txtCEP.Text = DgMedico.CurrentRow.Cells[3].Value.ToString();
            txtRua.Text = DgMedico.CurrentRow.Cells[4].Value.ToString();
            txtBairro.Text = DgMedico.CurrentRow.Cells[5].Value.ToString();
            txtCidade.Text = DgMedico.CurrentRow.Cells[6].Value.ToString();
            txtEstado.Text = DgMedico.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = DgMedico.CurrentRow.Cells[8].Value.ToString();
            txtCPF.Text = DgMedico.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
