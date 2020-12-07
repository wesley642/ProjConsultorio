using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjConsultorio.Classes
{
    public class ManutUser
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string SegundoNome { get; set; }

        public string SobreNome { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

    }
}
