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
    public partial class frmAlterarAgendamento : Form
    {
        private BaseRepository<Agendamento> repositorio = new BaseRepository<Agendamento>();
        public frmAlterarAgendamento()
        {
            InitializeComponent();
        }

        private void frmAlterarAgendamento_Load(object sender, EventArgs e)
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

        private void btnAlterarAgendamento_Click(object sender, EventArgs e)
        {

            frmEscolherDataAlterarAgendamento escolherDataAlterarAgendamento = new frmEscolherDataAlterarAgendamento(
                dtGridCancelarAgendamento.CurrentRow.Cells[0].Value.ToString(),
                dtGridCancelarAgendamento.CurrentRow.Cells[1].Value.ToString());
            escolherDataAlterarAgendamento.Show();
            Close();
        }
    }
}
