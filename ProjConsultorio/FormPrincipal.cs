using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjConsultorio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public int VerificarAdminLoginPrincipal { get; set; }

        private void btnPaciente_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FormPaciente>().Count() > 0)
            {
                MessageBox.Show("Janela já abérta", "ATENÇÃO");
            }
            else
            {
                Form Paciente = new FormPaciente();
                Paciente.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormMedico>().Count() > 0)
            {
                MessageBox.Show("Janela já abérta", "ATENÇÃO");
            }
            else
            {
                Form Medico = new FormMedico();
                Medico.Show();
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsulta>().Count() > 0)
            {
                MessageBox.Show("Janela já abérta", "ATENÇÃO");
            }
            else
            {
                Form Consulta = new FormConsulta();
                Consulta.Show();
            }
        }




        private void btnEspecialidade_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormEspecialidade>().Count() > 0)
            {
                MessageBox.Show("Janela já abérta", "ATENÇÃO");
            }
            else
            {
                Form Especialidade = new FormEspecialidade();
                Especialidade.Show();
            }
        }

        private void btnManutencaoUsuario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormManutUsuario>().Count() > 0)
            {
                MessageBox.Show("Janela já abérta", "ATENÇÃO");
            }
            else
            {
                Form UsuarioManutencao = new FormManutUsuario();
                UsuarioManutencao.Show();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (var tb = new Contexto())
            {
                DateTime Local = DateTime.Now;

                //DateTime VefData = Convert.ToDateTime( Local.ToString().Substring(0, 8).Replace("/", "");

                //string ex = "zika";

                //var objeto = tb.ObjetoConsulta.Where(a => a.Exame == ex).FirstOrDefault();              

                string DatalocalSubstring = Local.ToString().Substring(0, 10);
                DateTime DataConvertida = Convert.ToDateTime(DatalocalSubstring);

                var test = from tt in tb.ObjetoConsulta
                           join Medico in tb.ObjetoMedico
                           on tt.IdMedico equals Medico.IdMedico
                           join Paciente in tb.ObjetoPaciente
                           on tt.IdPaciente equals Paciente.IdPaciente
                           where tt.Data <= DataConvertida
                           select new { NomeMedico = Medico.Nome, NomePaciente = Paciente.Nome, tt.Data, tt.Exame };

                var xik = test.ToList();
                dgConsultas.DataSource = xik.ToList();

                

                //string NomePaciente, NomeMedico, Diagnostico;

                //var result = from Consulta in tb.ObjetoConsulta
                //             join Medico in tb.ObjetoMedico
                //             on Consulta.IdMedico equals Medico.IdMedico
                //             join Paciente in tb.ObjetoPaciente
                //             on Consulta.IdPaciente equals Paciente.IdPaciente
                //             select new { NomeMedico = Medico.Nome, NomePaciente = Paciente.Nome, Consulta.Data, Consulta.Exame };


            }
            lblagora.Text = DateTime.Now.ToString();

            if (VerificarAdminLoginPrincipal == 1)
            {
                btnManutencao.Visible = true;
            }
            else
            {
                btnManutencao.Visible = false;
            }

            lbldata.Text = DateTime.Now.ToString().Substring(0, 10)+" -";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblagora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
