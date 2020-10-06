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
    public partial class frmCadastrarAgendamento : Form
    {
        private BaseRepository<Agendamento> repositorio = new BaseRepository<Agendamento>();
        public frmCadastrarAgendamento()
        {
            InitializeComponent();
        }

        private void frmCadastrarAgendamento_Load(object sender, EventArgs e)
        {
            this.dtDataReserva.AddBoldedDate(new System.DateTime(2020, 10, 12));

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

            this.lblDetalhes.Text = "Data disponível";

            /*Color cor = new Color();
            cor = Color.FromArgb(127, 123, 147);
            this.dtDataReserva.ForeColor = cor;*/

            this.txtNomeCompleto.Text = "Rafael Peinado da Silva";
            this.txtApartamento.Text = "34";
        }

        private void btnCadastrarAgendamento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja agendar para o " 
                + this.dtDataReserva.SelectionStart.ToShortDateString()
                + " ?",
                "Confirmação de Agendamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                Close();
            }
        }
    }
}
