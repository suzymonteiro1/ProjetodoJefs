using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLEsportes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Projeto
{
    internal class FuncionarioContext
    {
        private readonly string _con = Conexao.StrConn;

        public string Adicionar(Funcionario funcionario)
        {
            string sql = "INSERT INTO Funcionarios (nome, cargo, email, data_contratacao) VALUES (@nome, @cargo, @email, @data_contratacao)";

            using (MySqlConnection con = new MySqlConnection(_con))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@data_contratacao", funcionario.DataContratacao);
                    cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                    cmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                    cmd.Parameters.AddWithValue("@estado", funcionario.Estado);
                    cmd.Parameters.AddWithValue("@senha", funcionario.Senha);

                    cmd.ExecuteNonQuery();
                }
            }

            return "ok";
        }
    }
}
