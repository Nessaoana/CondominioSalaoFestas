using condominio_salao_festas.Dominio.Entidades;
using condominio_salao_festas.Dominio.Enums;
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
        private BaseRepository<Apartamento> repositorioApartamento = new BaseRepository<Apartamento>();
        private ApartamentoRepository repositorioApUnico = new ApartamentoRepository();

        EscolhaForm escolhaSelecao;

        public CadastroMorador(EscolhaForm escolha, Usuario usuario)
        {
            InitializeComponent();
            escolhaSelecao = escolha;
            if (escolha.Equals(EscolhaForm.Alterar))
            {
                carregarCampos(usuario);
                cadastrar.Text = "Atualizar";
            }
            else
            {
                cadastrar.Text = "Cadastrar";
            }
            getApartamentos();
        }

        public void getApartamentos()
        {
            List<Apartamento> apartamentos = repositorioApartamento.SelectAll().ToList();
            cbApartamento.Items.Clear();

            cbApartamento.DataSource = apartamentos;
            cbApartamento.ValueMember = "NumeroApartamento";
        }
        public void carregarCampos(Usuario usuario)
        {
            txtId.Text = Convert.ToString(usuario.Id);
            txtNomeValor.Text = usuario.Nome;
            txtSenhaValor.Text = usuario.Senha;

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
            try
            {
                string mensagem = null;
                morador.Nome = txtNomeValor.Text;
                morador.Senha = txtSenhaValor.Text;

                Apartamento apartamento = this.cbApartamento.SelectedItem as Apartamento;
                morador.ApartamentoId = apartamento.Id;

                if (escolhaSelecao.Equals(EscolhaForm.Alterar))
                {
                    morador.Id = Convert.ToInt32(txtId.Text);
                    repositorio.Update(morador);
                    mensagem = "Morador atualizado";

                }
                else
                {

                    repositorio.Insert(morador);
                    mensagem = "Morador cadastrado";
                }

                MessageBox.Show(mensagem);
                this.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Preencha os campos corretamete", " Falta de dados ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void btnListaMoradoresMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMoradorMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnInicialAdmin_Click(object sender, EventArgs e)
        {

        }

        private void cbApartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
