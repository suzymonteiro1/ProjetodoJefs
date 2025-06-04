using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginCadastroApp.WinForms
{
    public partial class LoginForm : Form
    {
        private string connectionString = "server=localhost;database=login_db;uid=root;password=root;";

        public LoginForm()
        {
            InitializeComponent(); // Chama o método gerado automaticamente

            // Configurações adicionais após o InitializeComponent()
            this.Text = "Login";
            this.Size = new System.Drawing.Size(350, 200);

            // Cria e configura os controles
            Label lblEmail = new Label() { Text = "Email:", Location = new Point(0, 20) };
            TextBox txtEmail = new TextBox() { Location = new Point(100, 20), Width = 200 };

            Label lblSenha = new Label() { Text = "Senha:", Location = new Point(0, 60) };
            TextBox txtSenha = new TextBox() { Location = new Point(100, 60), Width = 200, PasswordChar = '*' };

            // Adiciona botão de login
            Button btnEntrar = new Button() { Text = "Entrar", Location = new Point(100, 100), Width = 100 };

            // Evento de clique do botão Entrar
            btnEntrar.Click += (s, e) =>
            {
                string email = txtEmail.Text;
                string senha = txtSenha.Text;

                if (ValidarLogin(email, senha))
                {
                    MessageBox.Show("✅ Login realizado com sucesso!");
                    this.Close(); // Fecha a janela de login
                }
                else
                {
                    MessageBox.Show("❌ Email ou senha inválidos.");
                }
            };

            // Adiciona os controles ao formulário
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblSenha);
            this.Controls.Add(txtSenha);
            this.Controls.Add(btnEntrar); // Adiciona o botão ao formulário
        }

        private bool ValidarLogin(string email, string senha)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE email = @email AND senha = @senha";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message);
                return false;
            }
        }
    }
}