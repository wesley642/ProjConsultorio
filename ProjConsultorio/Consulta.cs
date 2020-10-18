using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConsultorio
{
    public class Consulta
    {
        [Key]
        public int IdConsulta { get; set; }

        [ForeignKey("Medico")]
        public int IdMedico { get; set; }
        public Medico Medico { get; set; }

        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }

        public DateTime Data { get; set; }
        public Double Valor { get; set; }
        public string Diagnotico { get; set; }
        public string Exame { get; set; }
    }
}
