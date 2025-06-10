using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_do_SQL;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class CadastrarProdutos : Form
    {
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();

            // Atribuir valores corretamente
            produtos.Id = 0; // Se for necessário, ajuste isso conforme sua lógica
            produtos.Nome = TxtNome.Text;
            produtos.Descricao = TxtDescricao.Text;

            // Converter para decimal
            if (decimal.TryParse(TxtValor.Text, out decimal valor))
            {
                produtos.Valor = valor;
            }
            else
            {
                MessageBox.Show("O campo 'Valor' deve conter um número válido.");
                return;
            }

            produtos.Categoria = CmbCategoria.Text;

            // Converter para int
            if (int.TryParse(TxtEstoque.Text, out int estoque))
            {
                produtos.Estoque = estoque;
            }
            else
            {
                MessageBox.Show("O campo 'Estoque' deve conter um número inteiro válido.");
                return;
            }

            // Converter para DateOnly
            try
            {
                produtos.DataCadastro = DateTime.Parse(TxtDataCadastro.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("O campo 'Data de Cadastro' deve conter uma data válida.");
                return;
            }

            // Converter para decimal (peso, largura, altura, profundidade)
            if (decimal.TryParse(TxtPeso.Text, out decimal peso))
            {
                produtos.Peso = peso;
            }
            else
            {
                MessageBox.Show("O campo 'Peso' deve conter um número válido.");
                return;
            }

            if (decimal.TryParse(TxtLargura.Text, out decimal largura))
            {
                produtos.Largura = largura;
            }
            else
            {
                MessageBox.Show("O campo 'Largura' deve conter um número válido.");
                return;
            }

            if (decimal.TryParse(TxtAltura.Text, out decimal altura))
            {
                produtos.Altura = altura;
            }
            else
            {
                MessageBox.Show("O campo 'Altura' deve conter um número válido.");
                return;
            }

            if (decimal.TryParse(TxtProfundidade.Text, out decimal profundidade))
            {
                produtos.Profundidade = profundidade;
            }
            else
            {
                MessageBox.Show("O campo 'Profundidade' deve conter um número válido.");
                return;
            }
        }

            public string Adicionar(Produtos produtos)
        {
            var sql = "INSERT INTO Produtos (nome, descricao, valor, categoria, estoque, peso, largura, altura, profundidade) VALUES" +
                " (@nome, @descricao, @valor, @categoria, @estoque, @peso, @largura, @altura, @profundidade) ";

            MySqlConnection con = new MySqlConnection();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            { 
            cmd.Parameters.AddWithValue("@nome", produtos.Nome);
            cmd.Parameters.AddWithValue("@descricao", produtos.Descricao);
            cmd.Parameters.AddWithValue("@valor", produtos.Valor);
            cmd.Parameters.AddWithValue("@categoria", produtos.Categoria);
            cmd.Parameters.AddWithValue("@estoque", produtos.Estoque);
            cmd.Parameters.AddWithValue("@peso", produtos.Peso);
            cmd.Parameters.AddWithValue("@largura", produtos.Largura);
            cmd.Parameters.AddWithValue("@altura", produtos.Altura);
            cmd.Parameters.AddWithValue("@profundidade", produtos.Profundidade);

            cmd.ExecuteNonQuery();

                return "ok";
            }
    }
        }
    }
   
