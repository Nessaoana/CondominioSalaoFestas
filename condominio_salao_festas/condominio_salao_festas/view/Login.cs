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
    public partial class Login : Form
    {
        private BaseRepository<UsuarioAdmin> repositorio = new BaseRepository<UsuarioAdmin>();
        private BaseRepository<Usuario> repositorio1 = new BaseRepository<Usuario>();

        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UsuarioAdmin> users = repositorio.SelectAll().ToList();
            List<Usuario> users1 = repositorio1.SelectAll().ToList();

            foreach (UsuarioAdmin u in users)
            {
                if (u.Email.Equals(textBox1.Text) && u.Senha.Equals(textBox2.Text))
                {
                    Form1 inicial = new Form1(u, null);
                    inicial.Show();
                    this.Hide();
                    return;
                }
            }
            foreach (Usuario u in users1)
            {
                if (u.Nome.Equals(textBox1.Text) && u.Senha.Equals(textBox2.Text))
                {
                    Form1 inicial = new Form1(null, u);
                    inicial.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show(" Usuário e/ou senha inválida. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroAdmin cadastro = new CadastroAdmin(EscolhaForm.Cadastrar, null);
            cadastro.Show();
        }   
    }
}
