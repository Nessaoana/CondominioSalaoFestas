using condominio_salao_festas.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condominio_salao_festas.model.db_context
{
    public class BaseRepository<T> : IRepositorio<T> where T : EntidadeBase
    {
        private ApplicationDBContext context = new ApplicationDBContext();

		public void Insert(T obj)
		{
			context.Set<T>().Add(obj);
			context.SaveChanges();
		}

		public void Update(T obj)
		{
			context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
		}

		public void Remove(int id)
		{
			context.Set<T>().Remove(Select(id));
			context.SaveChanges();
		}

		public T Select(int id)
		{
			return context.Set<T>().Find(id);
		}

		public IList<T> SelectAll()
		{
			return context.Set<T>().ToList();
		}
	}
}
