using condominio_salao_festas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.Dominio.Entidades
{
    public class Apartamento : EntidadeBase

    {
        public Apartamento(string NumeroApartamento)
        {
            this.NumeroApartamento = NumeroApartamento;
        }

        public string NumeroApartamento { get; set; }

       

    }
}
