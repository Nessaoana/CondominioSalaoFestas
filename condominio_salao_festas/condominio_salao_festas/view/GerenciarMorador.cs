using condominio_salao_festas.Dominio.Enums;
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
    public partial class GerenciarMorador : Form
    {

        private BaseRepository<Usuario> repositorio = new BaseRepository<Usuario>();

        public GerenciarMorador()
        {
            InitializeComponent();
            getMoradoresToDataSet();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroMorador cm = new CadastroMorador(EscolhaForm.Cadastrar, null);
            cm.ShowDialog();
            getMoradoresToDataSet();
        }
        private List<Usuario> getMoradores()
        {
            repositorio = new BaseRepository<Usuario>();
            List<Usuario> moradores = null;
            moradores = repositorio.SelectAll().ToList();
            return moradores;
        }
        private void getMoradoresToDataSet()
        {
            List<Usuario> moradores = getMoradores();

            dgvMoradores.DataSource = null;
            dgvMoradores.DataSource = moradores;
            dgvMoradores.Refresh();
            dgvMoradores.Update();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMoradores.SelectedRows.Count < 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Usuario usuario = dgvMoradores.SelectedRows[0].DataBoundItem as Usuario;
                    try
                    {
                        repositorio.Remove(usuario.Id);
                        MessageBox.Show("Morador excluído");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    getMoradoresToDataSet();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMoradores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                Usuario morador = dgvMoradores.SelectedRows[0].DataBoundItem as Usuario;

                CadastroMorador cc = new CadastroMorador(EscolhaForm.Alterar, morador);

                cc.ShowDialog();
            }
            getMoradoresToDataSet();
        }
    }
}
