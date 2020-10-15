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

    public partial class GerenciarApartamento : Form
    {
        private BaseRepository<Apartamento> repositorio = new BaseRepository<Apartamento>();

        public GerenciarApartamento()
        {
            InitializeComponent();
            getApartamentosToDataSet();
        }

        private List<Apartamento> getApartamentos()
        {
            repositorio = new BaseRepository<Apartamento>();
            List<Apartamento> apartamentos = null;
            apartamentos = repositorio.SelectAll().ToList();
            return apartamentos;
        }

        private void getApartamentosToDataSet()
        {
            List<Apartamento> apartamentos = getApartamentos();

            dgvApartamentos.DataSource = null;
            dgvApartamentos.DataSource = apartamentos;
            dgvApartamentos.Refresh();
            dgvApartamentos.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroApartamento cm = new CadastroApartamento(EscolhaForm.Cadastrar, null);
            cm.ShowDialog();
            getApartamentosToDataSet();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvApartamentos.SelectedRows.Count < 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Apartamento apartamento = dgvApartamentos.SelectedRows[0].DataBoundItem as Apartamento;
                    try
                    {
                        repositorio.Remove(apartamento.Id);
                        MessageBox.Show("Apartamento excluído");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    getApartamentosToDataSet();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvApartamentos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                Apartamento apartamento = dgvApartamentos.SelectedRows[0].DataBoundItem as Apartamento;

                CadastroApartamento cc = new CadastroApartamento(EscolhaForm.Alterar, apartamento);

                cc.ShowDialog();
            }
            getApartamentosToDataSet();
        }

        private void dgvMoradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
