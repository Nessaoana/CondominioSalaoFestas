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
    public partial class frmEscolherDataAlterarAgendamento : Form
    {
        private BaseRepository<Agendamento> repositorio = new BaseRepository<Agendamento>();
        frmAlterarAgendamento alterarAgendamento = new frmAlterarAgendamento();
        public frmEscolherDataAlterarAgendamento()
        {
            InitializeComponent();
        }

        public frmEscolherDataAlterarAgendamento(string codigo, string dataAntes)
        {
            InitializeComponent();
            txtCodigoReserva.Text = codigo;
            txtDe.Text = dataAntes;
        }

        private void btnConfirmarAlteração_Click(object sender, EventArgs e)
        {
            if (verificarDisponiblidade(this.dtDataReserva.SelectionEnd.ToShortDateString()))
            {
                DialogResult resultado = MessageBox.Show("Deseja alterar para o dia "
                + this.dtDataReserva.SelectionStart.ToShortDateString()
                + "?",
                "Confirmação de alteração do Agendamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.DataAgendamento = this.dtDataReserva.SelectionStart.ToShortDateString();
                    agendamento.ApartamentoRef = this.txtApartamento.Text;
                    agendamento.Id = Convert.ToInt32(txtCodigoReserva.Text);
                    repositorio.Update(agendamento);
                    MessageBox.Show("Dia "
                    + this.dtDataReserva.SelectionStart.ToShortDateString()
                    + " reservado com sucesso!",
                    "Sucesso ao alterar reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Dia "
                    + this.dtDataReserva.SelectionStart.ToShortDateString()
                    + " está indisponível. Escolha outra data!",
                    "Erro ao alterar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            atualizarCalendario();
        }

        private void frmEscolherDataAlterarAgendamento_Load(object sender, EventArgs e)
        {
            atualizarCalendario();

            this.dtDataReserva.MinDate = new System.DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            // quando chega no mês 12 é preciso acrescentar 1 ano e colocar como mês 1
            if (DateTime.Today.Month != 12)
            {
                this.dtDataReserva.MaxDate = new System.DateTime(DateTime.Today.Year, (DateTime.Today.Month + 1), DateTime.DaysInMonth(DateTime.Today.Year, (DateTime.Today.Month + 1)));
            }
            else
            {
                this.dtDataReserva.MaxDate = new System.DateTime((DateTime.Today.Year + 1), 1, DateTime.DaysInMonth((DateTime.Today.Year + 1), 1));

            }

            /*Color cor = new Color();
            cor = Color.FromArgb(127, 123, 147);
            this.dtDataReserva.ForeColor = cor;*/

            this.txtNomeCompleto.Text = "Rafael Peinado da Silva";
            this.txtApartamento.Text = "3";

        }

        private void atualizarCalendario()
        {
            foreach (var agendamento in repositorio.SelectAll())
            {
                this.dtDataReserva.AddBoldedDate(Convert.ToDateTime(agendamento.DataAgendamento));
            }

        }

        private Boolean verificarDisponiblidade(String data)
        {
            foreach (var agendamento in repositorio.SelectAll())
            {
                if (data.Equals(agendamento.DataAgendamento))
                {
                    return false;
                }
            }
            return true;
        }

        private void dtDataReserva_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtPara.Text = this.dtDataReserva.SelectionEnd.ToShortDateString();
            if (verificarDisponiblidade(this.dtDataReserva.SelectionEnd.ToShortDateString()))
            {
                lblDetalhes.Text = "Obs: data disponível";
            }
            else
            {
                lblDetalhes.Text = "Obs: data indisponível";
            }
        }
    }
}
