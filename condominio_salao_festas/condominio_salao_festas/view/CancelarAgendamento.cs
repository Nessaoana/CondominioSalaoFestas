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
        }

        private void frmCancelarAgendamento_Load(object sender, EventArgs e)
        {
            this.txtNomeCompleto.Text = "Rafael Peinado da Silva";
            this.txtApartamento.Text = "3";

            atualizarTabela();
        }

        private void atualizarTabela()
        {
            DataTable tabela = new DataTable();

            tabela.Columns.Add("Código", typeof(string));
            tabela.Columns.Add("Data", typeof(string));

            DataRow Linha;
            foreach (var agendamento in repositorio.SelectAll())
            {
                Linha = tabela.NewRow();
                Linha[0] = agendamento.Id;
                Linha[1] = agendamento.DataAgendamento;
                tabela.Rows.Add(Linha);
            }
            dtGridCancelarAgendamento.DataSource = tabela;
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja cancelar o dia "
                + dtGridCancelarAgendamento.CurrentRow.Cells[1].Value.ToString()
                + "?",
                "Confirmação de Cancelamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.Id = int.Parse(dtGridCancelarAgendamento.CurrentRow.Cells[0].Value.ToString());
                    repositorio.Remove(agendamento.Id);
                    MessageBox.Show("Dia "
                    + dtGridCancelarAgendamento.CurrentRow.Cells[1].Value.ToString()
                    + " foi cancelado com sucesso!",
                    "Sucesso ao cancelar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    Close();
                }
        }
    }
}
