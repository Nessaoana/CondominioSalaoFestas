using condominio_salao_festas.Dominio.Interfaces;
using condominio_salao_festas.model;
using condominio_salao_festas.model.db_context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condominio_salao_festas.view
{
    public partial class CadastroAdmin : Form
    {
        private BaseRepository<UsuarioAdmin> repositorio = new BaseRepository<UsuarioAdmin>();

        public CadastroAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            UsuarioAdmin usuario = new UsuarioAdmin();

            usuario.Nome = txtNomeValor.Text;
            usuario.Email = txtEmailValor.Text;
            usuario.Senha = txtSenhaValor.Text;

            repositorio.Insert(usuario);

            this.Close();
        }

        private void nomeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
