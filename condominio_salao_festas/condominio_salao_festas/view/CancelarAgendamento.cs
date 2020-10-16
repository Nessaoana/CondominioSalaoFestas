using condominio_salao_festas.Dominio.Entidades;
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
    public partial class frmCancelarAgendamento : Form
    {
        private BaseRepository<Agendamento> repositorio = new BaseRepository<Agendamento>();
        public frmCancelarAgendamento()
        {
            InitializeComponent();
            this.btnCancelarAgendamento.Visible = Program.adm;
        }

        private void frmCancelarAgendamento_Load(object sender, EventArgs e)
        {
            this.txtNomeCompleto.Text = "Rafael Peinado da Silva";
            this.txtApartamento.Text = "3";

            atualizarTabela();
        }

        private void atualizarTabela()
        {

            repositorio = new BaseRepository<Agendamento>();
            List<Agendamento> agendamentos = repositorio.SelectAll().ToList();

            dtGridCancelarAgendamento.DataSource = null;
            dtGridCancelarAgendamento.DataSource = agendamentos;
            dtGridCancelarAgendamento.Refresh();
            dtGridCancelarAgendamento.Update();
            dtGridCancelarAgendamento.Columns[1].Visible = false;
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja cancelar o dia "
                + dtGridCancelarAgendamento.CurrentRow.Cells[0].Value.ToString()
                + "?",
                "Confirmação de Cancelamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.Id = int.Parse(dtGridCancelarAgendamento.CurrentRow.Cells[3].Value.ToString());
                    repositorio.Remove(agendamento.Id);
                    MessageBox.Show("Dia "
                    + dtGridCancelarAgendamento.CurrentRow.Cells[0].Value.ToString()
                    + " foi cancelado com sucesso!",
                    "Sucesso ao cancelar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    atualizarTabela();
                }
        }

        private void btnIrParaAgendamento_Click(object sender, EventArgs e)
        {
            frmCadastrarAgendamento cadastrarAgendamento = new frmCadastrarAgendamento();
            cadastrarAgendamento.ShowDialog();
            atualizarTabela();
        }
    }
}
