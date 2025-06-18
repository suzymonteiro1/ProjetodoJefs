using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class VisualizarProduto : Form
    {
        private DataGridView dgvProdutos;

        public VisualizarProduto()
        {
            InitializeComponent();
            InicializarDataGridView();  

        }

        private void InicializarDataGridView()
        {
            dgvProdutos = new DataGridView();
            dgvProdutos.Location = new Point(10, 10);  
            dgvProdutos.Size = new Size(760, 400);  
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.ReadOnly = true;

            this.Controls.Add(dgvProdutos);
        }

        private void VisualizarProduto_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                string conexao = "server=localhost;user id=root;password=;database=seu_banco_aqui";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string query = "SELECT Id, Nome, Descricao, Valor, Categoria, Estoque FROM Produtos";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgvProdutos.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }
    }
}
