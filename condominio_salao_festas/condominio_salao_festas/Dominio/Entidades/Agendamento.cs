using condominio_salao_festas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.Dominio.Entidades
{
    class Agendamento : EntidadeBase
    {
        public string DataAgendamento { get; set; }
        public string ApartamentoRef { get; set; }
    }
}
