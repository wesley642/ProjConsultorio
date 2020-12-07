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
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

      
        [ForeignKey("Especialidad")]
        public int IdEspecialidade { get; set; }
        

        public string Nome { get; set; }
        public string CEP { get; set; }//cep
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }///cep
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public Especialidad Especialidad { get; set; }


    }
}
