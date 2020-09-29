using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace condominio_salao_festas.model.db_context
{
    public class ApplicationDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = CondominioDB; Trusted_Connection=True;");
        }

        // conforme as classes existirem a gente precisa mapear elas nessa classe para virar uma tabela
        // exemplo:
        // public DbSet<Aluno> Alunos { get; set; }

        public System.Data.Entity.DbSet<Usuario> Usuarios { get; set; }

        // Toda vez que adicionarem uma nova tabela neste arquivo rode o comando abaixo
        // Update-Database
        // ele vai criar o banco de dados 
        // ps: precisa instalar o sql server sim..


        // Para usar o banco de dados você precisa instanciar  uma variável:
        // private ApplicationDBContext bancoDados = new ApplicationDBContext();
        // para manipular a tabela:
        // bancoDados.<nome_da_tabela>.<ação>();
        // Para selecionar dados de todos os usuários:
        // bancoDados.Usuarios.ToList();
    }
}
