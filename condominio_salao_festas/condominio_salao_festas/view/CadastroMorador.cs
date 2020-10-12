using condominio_salao_festas.Dominio.Entidades;
using condominio_salao_festas.Infra.Data;
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
    public partial class CadastroMorador : Form
    {
        private BaseRepository<Usuario> repositorio = new BaseRepository<Usuario>();
        private ApartamentoRepository repositorioAp = new ApartamentoRepository();

        public CadastroMorador()
        {
            InitializeComponent();
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Usuario morador = new Usuario();

            morador.Nome = txtNomeValor.Text;

            var apartamento = repositorioAp.SelectNumeroAp(this.txtApartamentoValor.Text);

            if(apartamento == null)
                apartamento = new Apartamento(txtApartamentoValor.Text);

            morador.ApartamentoRef = apartamento;
            morador.Senha = txtSenhaValor.Text;

            repositorio.Insert(morador);

            this.Close();
        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroMorador_Load(object sender, EventArgs e)
        {

        }
    }
}
