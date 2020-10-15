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
    public partial class frmCadastrarAgendamento : Form
    {
        private BaseRepository<Agendamento> repositorio = new BaseRepository<Agendamento>();
        private BaseRepository<Usuario> repositorioMorador = new BaseRepository<Usuario>();


        public frmCadastrarAgendamento()
        {
            InitializeComponent();
            getApartamentos();
        }
        public void getApartamentos()
        {
            List<Usuario> moradores = repositorioMorador.SelectAll().ToList();
            cbMoradores.Items.Clear();

            cbMoradores.DataSource = moradores;
            cbMoradores.ValueMember = "Nome";
        }

        private void frmCadastrarAgendamento_Load(object sender, EventArgs e)
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

        private void btnCadastrarAgendamento_Click(object sender, EventArgs e)
        {
            if (verificarDisponiblidade(this.dtDataReserva.SelectionEnd.ToShortDateString()))
            {
                DialogResult resultado = MessageBox.Show("Deseja agendar para o "
                + this.dtDataReserva.SelectionStart.ToShortDateString()
                + "?",
                "Confirmação de Agendamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.DataAgendamento = this.dtDataReserva.SelectionStart.ToShortDateString();
                    agendamento.ApartamentoId = Convert.ToInt32(this.txtApartamento.Text);                        
                    repositorio.Insert(agendamento);
                    MessageBox.Show("Dia "
                    + this.dtDataReserva.SelectionStart.ToShortDateString()
                    + " reservado com sucesso!",
                    "Sucesso ao reservar",
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
                    "Erro ao reservar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            atualizarCalendario();            
        }

        private void dtDataReserva_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (verificarDisponiblidade(this.dtDataReserva.SelectionEnd.ToShortDateString()))
            {
                lblDetalhes.Text = "Obs: data disponível";
            }
            else
            {
                lblDetalhes.Text = "Obs: data indisponível";
            }
        }

        private void cbMoradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario morador = cbMoradores.SelectedItem as Usuario;
            txtApartamento.Text = Convert.ToString(morador.ApartamentoId);
        }

        private void txtApartamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
