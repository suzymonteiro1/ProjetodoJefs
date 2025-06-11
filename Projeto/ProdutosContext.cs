using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DLLEsportes;

namespace Projeto
{
    public class ProdutosContext
    {
        private readonly string _con = Conexao.StrConn;
        public string Adicionar(Produtos produto)
        {
            var sql = "INSERT INTO Produtos (nome, descricao, valor, categoria, estoque, peso, largura, altura, profundidade) VALUES" +
                " (@nome, @descricao, @valor, @categoria, @estoque, @peso, @largura, @altura, @profundidade) ";

            MySqlConnection con = new MySqlConnection();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            {
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@valor", produto.Valor);
                cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cmd.Parameters.AddWithValue("@peso", produto.Peso);
                cmd.Parameters.AddWithValue("@largura", produto.Largura);
                cmd.Parameters.AddWithValue("@altura", produto.Altura);
                cmd.Parameters.AddWithValue("@profundidade", produto.Profundidade);

                cmd.ExecuteNonQuery();

                return "ok";
            }
        }
    }
}
