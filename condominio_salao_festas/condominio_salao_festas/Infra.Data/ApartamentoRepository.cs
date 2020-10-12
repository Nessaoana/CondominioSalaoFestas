using condominio_salao_festas.Dominio.Entidades;
using condominio_salao_festas.model.db_context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.Infra.Data
{
    public class ApartamentoRepository : BaseRepository<Apartamento>
    {
        private ApplicationDBContext context = new ApplicationDBContext();

        public Apartamento SelectNumeroAp(string numeroAp)
        {
            return context.Apartamentos.Where(b => b.NumeroApartamento == numeroAp).FirstOrDefault();
        }
    }
}
