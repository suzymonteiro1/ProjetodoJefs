using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginCadastroApp.WinForms
{
    public partial class CadastroForm : Form
    {
        private string connectionString = "server=localhost;database=login_db;uid=root;password=root;";

        // Declarando os controles aqui para acessá-los em qualquer lugar da classe
        private TextBox txtEmail;
        private TextBox txtSenha;

        public CadastroForm()
        {
            InitializeComponent(); // Chama o método gerado automaticamente

            // Configurações adicionais após o InitializeComponent()
            this.Text = "Cadastro";
            this.Size = new Size(350, 220);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Labels
            Label lblEmail = new Label()
            {
                Text = "Email:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            Label lblSenha = new Label()
            {
                Text = "Senha:",
                Location = new Point(20, 60),
                AutoSize = true
            };

            // Campos de texto
            txtEmail = new TextBox()
            {
                Location = new Point(100, 16),
                Width = 200
            };

            txtSenha = new TextBox()
            {
                Location = new Point(100, 56),
                Width = 200,
                PasswordChar = '*'
            };

            // Botões
            Button btnCadastrar = new Button()
            {
                Text = "Cadastrar",
                Location = new Point(100, 100),
                Width = 90
            };

            Button btnCancelar = new Button()
            {
                Text = "Cancelar",
                Location = new Point(210, 100),
                Width = 90
            };

            // Eventos dos botões
            btnCadastrar.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("⚠️ Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CadastrarUsuario(txtEmail.Text, txtSenha.Text))
                {
                    MessageBox.Show("✅ Cadastro realizado com sucesso!");
                    LimparCampos();
                    this.Close();
                }
                else
                {
                    // Erro já mostrado dentro de CadastrarUsuario()
                }
            };

            btnCancelar.Click += (s, e) =>
            {
                this.Close();
            };

            // Adicionando os controles ao formulário
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblSenha);
            this.Controls.Add(txtSenha);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnCancelar);
        }

        private bool CadastrarUsuario(string email, string senha)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO usuarios (email, senha) VALUES (@email, @senha)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("❌ Esse email já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("⚠️ Erro ao conectar ao banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
        }
    }
}