using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Projeto;

namespace DLL_do_SQL
{
    public class Produtos
    {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public decimal Valor { get; set; }
            public string Categoria { get; set; }
            public int Estoque { get; set; }
            public DateTime DataCadastro { get; set; }
            public decimal Peso { get; set; }
            public decimal Largura { get; set; }
            public decimal Altura { get; set; }
            public decimal Profundidade { get; set; }

        public string Validar()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(Nome))
                result += "Informe o nome do produto.";

            if (string.IsNullOrWhiteSpace(Descricao))
                result += "\nInforme a marca do produto.";

            if (string.IsNullOrWhiteSpace(Valor.ToString()))
                result += "\nInforme o fabricante do produto.";

            if (string.IsNullOrWhiteSpace(Categoria))
                result += "\nInforme o sabor do produto.";

            if (string.IsNullOrWhiteSpace(Estoque.ToString()))
                result += "\nInforme a unidade do produto.";

            if (Validador.DataValidar(DataCadastro.ToString()))
                result += "\nA data de validade do produto é inválida.";

            if (string.IsNullOrWhiteSpace(Largura.ToString()))
                result += "\nInforme a quantidade em estoque do produto, pode ser zero.";

            if (string.IsNullOrWhiteSpace(Altura.ToString()))
                result += "\nInforme a quantidade em estoque do produto, pode ser zero.";

            if (string.IsNullOrWhiteSpace(Profundidade.ToString()))
                result += "\nInforme a quantidade em estoque do produto, pode ser zero.";

            return result == "" ? "ok" : result;
        }
    }
}
