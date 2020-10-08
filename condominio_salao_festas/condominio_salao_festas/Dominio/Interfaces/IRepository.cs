using condominio_salao_festas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.Dominio.Interfaces
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
