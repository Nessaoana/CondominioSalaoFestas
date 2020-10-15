using condominio_salao_festas.Dominio.Enums;
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
        EscolhaForm escolhaSelecao;

        public CadastroAdmin(EscolhaForm escolha, UsuarioAdmin usuario)
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
        }
        public void carregarCampos(UsuarioAdmin usuario)
        {
            txtId.Text = Convert.ToString(usuario.Id);
            txtEmailValor.Text = usuario.Email;
            txtNomeValor.Text = usuario.Nome;
            txtSenhaValor.Text = usuario.Senha;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            UsuarioAdmin usuario = new UsuarioAdmin();
            try
            {
                string mensagem = null;
                usuario.Nome = txtNomeValor.Text;
                usuario.Email = txtEmailValor.Text;
                usuario.Senha = txtSenhaValor.Text;

                if (escolhaSelecao.Equals(EscolhaForm.Alterar))
                {
                    usuario.Id = Convert.ToInt32(txtId.Text);       
                    repositorio.Update(usuario);
                    mensagem = "Usuário atualizado";      

                }
                else
                {
                    repositorio.Insert(usuario);
                    mensagem = "Usuário cadastrado";
                }
      
                MessageBox.Show(mensagem);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos corretamete", " Falta de dados ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
