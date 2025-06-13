using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLEsportes;
using MySql.Data.MySqlClient;

namespace Projeto
{
        public class ClientesContext
        {
            private readonly string _con = Conexao.StrConn;
            public string Adicionar(Clientes clientes)
            {
                var sql = "INSERT INTO Produtos (nome, cpf, bairro, cidade, estado, email, senha) VALUES" +
                    " (@nome, @cpf, @bairro, @cidade, @estado, @email, @senha) ";

                MySqlConnection con = new MySqlConnection(_con);
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                {
                    cmd.Parameters.AddWithValue("@nome", clientes.Nome);
                    cmd.Parameters.AddWithValue("@cpf", clientes.Cpf);
                    cmd.Parameters.AddWithValue("@bairro", clientes.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", clientes.Cidade);
                    cmd.Parameters.AddWithValue("@estado", clientes.Estado);
                    cmd.Parameters.AddWithValue("@email", clientes.Email);
                    cmd.Parameters.AddWithValue("@senha", clientes.Senha);

                    cmd.ExecuteNonQuery();

                    return "ok";
                }
            }
        }
    }
