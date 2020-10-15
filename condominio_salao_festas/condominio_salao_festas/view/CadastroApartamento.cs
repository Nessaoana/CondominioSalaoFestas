using condominio_salao_festas.Dominio.Entidades;
using condominio_salao_festas.Dominio.Enums;
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
    public partial class CadastroApartamento : Form
    {
        private BaseRepository<Apartamento> repositorio = new BaseRepository<Apartamento>();
        EscolhaForm escolhaSelecao;
        public CadastroApartamento(EscolhaForm escolha, Apartamento apartamento)
        {
            InitializeComponent();
            escolhaSelecao = escolha;
            if (escolha.Equals(EscolhaForm.Alterar))
            {
                carregarCampos(apartamento);
                btnCadastrar.Text = "Atualizar";
            }
            else
            {

                btnCadastrar.Text = "Cadastrar";
            }
        }
        public void carregarCampos(Apartamento apartamento)
        {
            txtId.Text = Convert.ToString(apartamento.Id);
            txtNumApartamento.Text = apartamento.NumeroApartamento;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Apartamento apartamento = new Apartamento("");
            try
            {
                string mensagem = null;
                apartamento.NumeroApartamento = txtNumApartamento.Text;

                if (escolhaSelecao.Equals(EscolhaForm.Alterar))
                {
                    apartamento.Id = Convert.ToInt32(txtId.Text);
                    repositorio.Update(apartamento);
                    mensagem = "Apartamento atualizado";

                }
                else
                {
                    repositorio.Insert(apartamento);
                    mensagem = "Apartamento cadastrado";
                }

                MessageBox.Show(mensagem);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos corretamete", " Falta de dados ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
