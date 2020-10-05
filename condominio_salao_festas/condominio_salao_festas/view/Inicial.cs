using condominio_salao_festas.model;
using condominio_salao_festas.model.db_context;
using condominio_salao_festas.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condominio_salao_festas
{
    public partial class Form1 : Form
    {
        private ApplicationDBContext ctx = new ApplicationDBContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroAdmin cadastro = new CadastroAdmin();

            cadastro.ShowDialog();

        }
    }
}
