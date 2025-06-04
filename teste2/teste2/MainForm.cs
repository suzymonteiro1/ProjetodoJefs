using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginCadastroApp.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); // Chama o método gerado automaticamente

            // Configurações adicionais após o InitializeComponent()
            this.Text = "Loja Esportiva";
            this.Size = new System.Drawing.Size(400, 300);

            // Adiciona eventos aos botões
            btnLogin.Click += (s, e) => new LoginForm().ShowDialog();
            btnCadastro.Click += (s, e) => new CadastroForm().ShowDialog();
            btnProdutos.Click += (s, e) => new ProdutosForm().ShowDialog();
            btnSair.Click += (s, e) => Application.Exit();

            // Adiciona os botões ao formulário
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnCadastro);
            this.Controls.Add(btnProdutos);
            this.Controls.Add(btnSair);
        }
    }
}