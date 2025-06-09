using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_do_SQL;

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

            // Após validar e converter todos os campos, você pode salvar o produto no banco de dados
            // Exemplo: SalvarProduto(produtos);
        }
    }
    }
