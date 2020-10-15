using condominio_salao_festas.Dominio.Enums;
using condominio_salao_festas.model;
using condominio_salao_festas.model.db_context;
using condominio_salao_festas.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condominio_salao_festas
{
    public partial class Form1 : Form
    {
        private ApplicationDBContext ctx = new ApplicationDBContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroAdmin cadastro = new CadastroAdmin(EscolhaForm.Cadastrar, null);

            cadastro.ShowDialog();

        }

        private void btnIrParaAgendamento_Click(object sender, EventArgs e)
        {
            frmCadastrarAgendamento cadastrarAgendamento = new frmCadastrarAgendamento();
            cadastrarAgendamento.Show();
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            frmCancelarAgendamento cancelarAgendamento = new frmCancelarAgendamento();
            cancelarAgendamento.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   

            GerenciarMorador cadastroMorador = new GerenciarMorador();
            cadastroMorador.Show();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            GerenciarUsuario gerenciarUsuario = new GerenciarUsuario();
            gerenciarUsuario.Show();
        }

        private void btnApartamentos_Click(object sender, EventArgs e)
        {
            GerenciarApartamento gerenciarApartamento = new GerenciarApartamento();
            gerenciarApartamento.Show();
        }
    }
}
