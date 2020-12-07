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


namespace ProjConsultorio
{
    public partial class FormEspecialidade : Form
    {
        public FormEspecialidade()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtID.Clear();
            txtEspecialidade.Clear();
        }


        public void AtualizarGrid()
        {
            using (var tb = new Contexto())
            {
                gridEspecialidade.DataSource = null;
                gridEspecialidade.DataSource = tb.ObjetoEspecialidade.ToList();
            }
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                //Pesquisa Para Saber se ja existe a especialidade no banco de dados cadastrada!
                var Pesquisa = new Contexto();
                string TextoEspecialidade;
                TextoEspecialidade = txtEspecialidade.Text;
                var ObjetoPesquisaEspecialidade = Pesquisa.ObjetoEspecialidade.Where(a => a.Especialidade == TextoEspecialidade).FirstOrDefault();
                //


                if (txtEspecialidade.Text == "")
                {
                    MessageBox.Show("Preencha os campos necessários!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtID.Text != string.Empty)
                    {
                        txtID.Clear();
                        txtEspecialidade.Clear();

                        if (ObjetoPesquisaEspecialidade == null)
                        {
                            using (var tb = new Contexto())
                            {
                                tb.ObjetoEspecialidade.Add(new Especialidad { Especialidade = txtEspecialidade.Text });
                                tb.SaveChanges();
                            }
                            LimparCampos();
                            AtualizarGrid();
                            MessageBox.Show("Incluido com súcesso", "Inclusão");
                        }
                        else
                        {
                            MessageBox.Show("Especialidade já existe!");
                        }


                    }
                    else
                    {
                        if (ObjetoPesquisaEspecialidade == null)
                        {
                            using (var tb = new Contexto())
                            {
                                tb.ObjetoEspecialidade.Add(new Especialidad { Especialidade = txtEspecialidade.Text });
                                tb.SaveChanges();
                            }
                            LimparCampos();
                            AtualizarGrid();
                            MessageBox.Show("Incluido com súcesso", "Inclusão");
                        }
                        else
                        {
                            MessageBox.Show("Especialidade já existe!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEspecialidade_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtEspecialidade.Text == "")
                {
                    MessageBox.Show("Preencha os campos necessários!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (var tb = new Contexto())
                    {
                        var objeto = tb.ObjetoEspecialidade.Find(Convert.ToInt32(txtID.Text));
                        tb.ObjetoEspecialidade.Remove(objeto);
                        tb.SaveChanges();
                        MessageBox.Show("Especialidade excluida com Sucesso", "Exclusão");
                        LimparCampos();
                        AtualizarGrid();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Erro na operação.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Preencha os campos necessários!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (var tb = new Contexto())
                    {

                        var objeto = tb.ObjetoEspecialidade.Find(Convert.ToInt32(txtID.Text));

                        objeto.Especialidade = txtEspecialidade.Text;

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

        private void gridEspecialidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gridEspecialidade.CurrentRow.Cells[0].Value.ToString();
            txtEspecialidade.Text = gridEspecialidade.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
