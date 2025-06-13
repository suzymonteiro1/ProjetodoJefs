using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLEsportes;

namespace Projeto
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente frm = new CadastroCliente();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginParaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginCliente frm = new FrmLoginCliente();
            frm.Show();
        }

        private void loginParaFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginFuncionario frm = new FrmLoginFuncionario();
            frm.Show();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProdutos frm = new CadastrarProdutos();
            frm.Show();
        }
    }
}
