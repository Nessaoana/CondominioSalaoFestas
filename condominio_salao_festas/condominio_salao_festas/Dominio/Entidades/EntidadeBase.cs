using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.model
{
    public abstract class EntidadeBase
    {
        public virtual int Id { get; set; }
    }
}
