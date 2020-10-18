using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConsultorio
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Convenio { get; set; }
        public string Plano { get; set; }
        public string NumCartao { get; set; }
    }
}
