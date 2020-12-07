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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
            txtDataHora.Text = DateTime.Now.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtExame.Text == "" || txtValor.Text == "" || txtDiagonostico.Text == "")
                {
                    MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (var tb = new Contexto())
                    {
                        tb.ObjetoConsulta.Add(new Consulta { IdMedico = Convert.ToInt32(txtMedico.SelectedValue), IdPaciente = Convert.ToInt32(txtPaciente.SelectedValue), Exame = txtExame.Text, Diagnotico = txtDiagonostico.Text, Data = Convert.ToDateTime(txtDataHora.Text), Valor = Convert.ToDouble(txtValor.Text) });
                        tb.SaveChanges();
                        LimparCampos();
                        MessageBox.Show("Incluido com Sucesso", "Inclusão");
                        AtualizarGrid();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Errou");
            }
        }




        private void FormConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBConsultorioConsulta.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.dBConsultorioConsulta.Consultas);
            AtualizarGrid();
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioDataSet1.Pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pacientesTableAdapter.Fill(this.dbConsultorioDataSet1.Pacientes);
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioDataMedicoSelect.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.dbConsultorioDataMedicoSelect.Medicos);
            // TODO: esta linha de código carrega dados na tabela 'dbConsultorioEspecialidadeSelect.Especialidads'. Você pode movê-la ou removê-la conforme necessário.
            this.especialidadsTableAdapter.Fill(this.dbConsultorioEspecialidadeSelect.Especialidads);


            

            var contexto = new Contexto();

            string NomePaciente, NomeMedico,Diagnostico;

            var result = from Consulta in contexto.ObjetoConsulta
                         join Medico in contexto.ObjetoMedico
                         on Consulta.IdMedico equals Medico.IdMedico
                         join   Paciente in contexto.ObjetoPaciente
                         on Consulta.IdPaciente  equals Paciente.IdPaciente

                         select new { Consulta.IdConsulta,NomeMedico = Medico.Nome, NomePaciente = Paciente.Nome ,Consulta.Data, Consulta.Valor, Diagnostico = Consulta.Diagnotico, Consulta.Exame};             
                         dgConsulta.DataSource = result.ToList();  
        }

        public void LimparCampos()
        {
            txtIdMedico.Clear();
            txtDataHora.Clear();
            txtValor.Clear();
            txtExame.Clear();
            txtDiagonostico.Clear();
            txtPaciente.SelectedIndex = -1;
            txtMedico.SelectedIndex = -1;
        }

        public void AtualizarGrid()
        {
            //using (var tb = new Contexto())
            //{
            //    gridConsulta.DataSource = null;
            //    gridConsulta.DataSource = tb.ObjetoConsulta.ToList();
            //}


            var contexto = new Contexto();

            string NomePaciente, NomeMedico, Diagnostico;

            var result = from Consulta in contexto.ObjetoConsulta
                         join Medico in contexto.ObjetoMedico
                         on Consulta.IdMedico equals Medico.IdMedico
                         join Paciente in contexto.ObjetoPaciente
                         on Consulta.IdPaciente equals Paciente.IdPaciente

                         select new { Consulta.IdConsulta, NomeMedico = Medico.Nome, NomePaciente = Paciente.Nome, Consulta.Data, Consulta.Valor, Diagnostico = Consulta.Diagnotico, Consulta.Exame };
            dgConsulta.DataSource = result.ToList();


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
                        var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtIdMedico.Text));

                        //////////////////////////////////////////////// ENCONTRAR ID DO MEDICO

                        int ResultadoPesquisaMedico;
                        string TextoMedico;
                        TextoMedico = txtMedico.Text;

                        //var test = from tt in tb.ObjetoMedico
                        //           where tt.Nome.Equals(txtMedico.Text)
                        //           select tt.IdMedico;

                        var ObjetoPesquisaMedico = tb.ObjetoMedico.Where(a => a.Nome == TextoMedico).FirstOrDefault();
                        ResultadoPesquisaMedico = ObjetoPesquisaMedico.IdMedico;

                        //////////////////////////////////////////////////EncontrarIdMedico
                        objeto.IdMedico = ResultadoPesquisaMedico;///////IdMedico   


                        //////////////////////////////////////////////////////////////
                        int ResultadoPesquisaPaciente;
                        string TextoPaciente;
                        TextoPaciente = txtPaciente.Text;

                        var ObjetoPesquisaPaciente = tb.ObjetoPaciente.Where(a => a.Nome == TextoPaciente).FirstOrDefault();

                        ResultadoPesquisaPaciente = ObjetoPesquisaPaciente.IdPaciente;
                        //////////////////////////////////////////////////////Encontrar IdPaciente
                        objeto.IdPaciente = ResultadoPesquisaPaciente;///////IdPaciente


                        objeto.Data = Convert.ToDateTime(txtDataHora.Text);
                        objeto.Valor = Convert.ToDouble(txtValor.Text);
                        objeto.Diagnotico = txtDiagonostico.Text;
                        objeto.Exame = txtExame.Text;


                        tb.Entry(objeto).State = EntityState.Modified;
                        tb.SaveChanges();
                        MessageBox.Show("Alterado com Sucesso", "Alteração");
                        AtualizarGrid();
                        LimparCampos();
                    }
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void gridConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtIdMedico.Text = gridConsulta.CurrentRow.Cells[0].Value.ToString();

        //    //using (var tb = new Contexto())
        //    //{
        //    //    try
        //    //    {
        //    //        int medicID;

        //    //        medicID = Convert.ToInt32(gridConsulta.CurrentRow.Cells[1].Value);
        //    //        var objeto = tb.ObjetoMedico.Find(medicID);
        //    //        txtMedico.Text = objeto.Nome;

        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show(ex.Message);
        //    //    }
        //    //}



        //    //using (var tb = new Contexto())
        //    //{
        //    //    try
        //    //    {
        //    //        int medicID;

        //    //        medicID = Convert.ToInt32(gridConsulta.CurrentRow.Cells[2].Value);
        //    //        var objeto = tb.ObjetoPaciente.Find(medicID);
        //    //        txtPaciente.Text = objeto.Nome;
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show(ex.Message);
        //    //    }
        //    //}

        //    txtDataHora.Text = gridConsulta.CurrentRow.Cells[3].Value.ToString();
        //    txtValor.Text = gridConsulta.CurrentRow.Cells[4].Value.ToString();
        //    txtDiagonostico.Text = gridConsulta.CurrentRow.Cells[5].Value.ToString();
        //    txtExame.Text = gridConsulta.CurrentRow.Cells[6].Value.ToString();
        //}

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIdMedico.Text == "")
                {
                    MessageBox.Show("Preencha os campos necessários para efetuar o cadastro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (var tb = new Contexto())
                    {
                        var objeto = tb.ObjetoConsulta.Find(Convert.ToInt32(txtIdMedico.Text));
                        tb.ObjetoConsulta.Remove(objeto);
                        tb.SaveChanges();
                        MessageBox.Show("Excluido com Sucesso", "Exclusão");
                        AtualizarGrid();
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = dgConsulta.CurrentRow.Cells[0].Value.ToString();
            txtMedico.Text = dgConsulta.CurrentRow.Cells[1].Value.ToString();
            txtPaciente.Text = dgConsulta.CurrentRow.Cells[2].Value.ToString();
            txtDataHora.Text = dgConsulta.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = dgConsulta.CurrentRow.Cells[4].Value.ToString();
            txtDiagonostico.Text = dgConsulta.CurrentRow.Cells[5].Value.ToString();
            txtExame.Text = dgConsulta.CurrentRow.Cells[6].Value.ToString();
        }

    }
}
