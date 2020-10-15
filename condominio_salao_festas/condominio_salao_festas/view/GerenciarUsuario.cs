using condominio_salao_festas.Dominio.Entidades;
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
    public partial class GerenciarUsuario : Form
    {
        private BaseRepository<UsuarioAdmin> repositorio = new BaseRepository<UsuarioAdmin>();
        public GerenciarUsuario()
        {
            InitializeComponent();
            getUsuariosToDataSet();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                UsuarioAdmin usuario = dgvUsers.SelectedRows[0].DataBoundItem as UsuarioAdmin;

                CadastroAdmin cc = new CadastroAdmin(EscolhaForm.Alterar, usuario);

                cc.ShowDialog();
            }
            getUsuariosToDataSet();
        }
        private List<UsuarioAdmin> getUsuarios()
        {   
            repositorio = new BaseRepository<UsuarioAdmin>();
            List<UsuarioAdmin> usuarios = null;
            usuarios = repositorio.SelectAll().ToList();
            return usuarios;
        }

        private void getUsuariosToDataSet()
        {
            List<UsuarioAdmin> usuarios = getUsuarios();

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = usuarios;
            dgvUsers.Refresh();
            dgvUsers.Update();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count < 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuarioAdmin usuario = dgvUsers.SelectedRows[0].DataBoundItem as UsuarioAdmin;
                    try
                    {
                        repositorio.Remove(usuario.Id);
                        MessageBox.Show("Usuário excluído");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("" + ex);
                    }
                    getUsuariosToDataSet();
                }

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroAdmin ca = new CadastroAdmin(EscolhaForm.Cadastrar, null);
            ca.ShowDialog();
            getUsuariosToDataSet();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}