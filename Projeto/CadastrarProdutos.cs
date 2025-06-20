﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DLLEsportes;

namespace Projeto
{
    public partial class CadastrarProdutos : Form
    {

        Produtos _produtos = new Produtos();
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _produtos.Id = 0;
            _produtos.Nome = TxtNome.Text;
            _produtos.Descricao = TxtDescricao.Text;
            _produtos.Valor = decimal.Parse("0" + TxtValor.Text);
            _produtos.Categoria = CmbCategoria.Text;
            _produtos.Estoque = int.Parse("0" + TxtEstoque.Text);
            _produtos.Peso = decimal.Parse("0" + TxtPeso.Text);
            _produtos.Largura = decimal.Parse("0" + TxtLargura.Text);
            _produtos.Altura = decimal.Parse("0" + TxtAltura.Text);
            _produtos.Profundidade = decimal.Parse("0" + TxtProfundidade.Text);
            

            var result = _produtos.Adicionar();
            if (result == "ok")
                MessageBox.Show("Salvo com sucesso");

            else
                MessageBox.Show("Falha" + result);
        }

        }
    }
   
