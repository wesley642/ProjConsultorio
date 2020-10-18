using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConsultorio
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidade { get; set; }
        public string Especialidade { get; set; }
    }
}
