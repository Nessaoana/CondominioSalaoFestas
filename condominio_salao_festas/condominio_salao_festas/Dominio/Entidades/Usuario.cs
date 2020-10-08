using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.model
{   
    public class Usuario : EntidadeBase
    {
        [ForeignKey("Apartamento")]
        public string Apartamento { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
