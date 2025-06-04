using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LoginCadastroApp.WinForms
{
    public partial class ProdutosForm : Form
    {
        private string connectionString = "server=localhost;database=login_db;uid=root;password=root;";

        public ProdutosForm()
        {
            InitializeComponent(); // Chama o método gerado automaticamente

            // Configurações adicionais após o InitializeComponent()
            this.Text = "Produtos da Loja";
            this.Size = new System.Drawing.Size(1000, 400);

            // Cria e configura o DataGridView
            DataGridView dgvProdutos = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true
            };

            this.Controls.Add(dgvProdutos);
            CarregarProdutos(dgvProdutos); // Chama o método para carregar os produtos
        }

        private void CarregarProdutos(DataGridView dgv)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, nome, descricao, valor, categoria, estoque, peso, largura, altura, profundidade FROM Produtos";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            var table = new System.Data.DataTable();
                            adapter.Fill(table);
                            dgv.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }
    }
}