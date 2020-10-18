using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConsultorio
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Conexao")
        {

        }


        public DbSet<Consulta> ObjetoConsulta { get; set; }

        public DbSet<Medico> ObjetoMedico { get; set; }

        public DbSet<Paciente> ObjetoPaciente { get; set; }

        public DbSet<Especialidad> ObjetoEspecialidade { get; set; }


    }
}
