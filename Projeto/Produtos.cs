using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DLLEsportes;

namespace Projeto
{
    public class Produtos
    {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public decimal Valor { get; set; }
            public string Categoria { get; set; }
            public int Estoque { get; set; }
            public string DataCadastro { get; set; }
            public decimal Peso { get; set; }
            public decimal Largura { get; set; }
            public decimal Altura { get; set; }
            public decimal Profundidade { get; set; }

        private ProdutosContext _produtosContext = new ProdutosContext();

        public string Adicionar()
        {
            var result = Validar();
            if (result == "ok")
                return _produtosContext.Adicionar(this);
            else
                return result;
        }

        public string Validar()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(Nome))
                result += "Informe o nome do produto.";

            if (string.IsNullOrWhiteSpace(Descricao))
                result += "\nInforme a descrição do produto.";

            if (string.IsNullOrWhiteSpace(Valor.ToString()))
                result += "\nInforme o valor do produto.";

            if (string.IsNullOrWhiteSpace(Categoria))
                result += "\nInforme a categoria do produto.";

            if (string.IsNullOrWhiteSpace(Estoque.ToString()))
                result += "\nInforme a unidade do produto.";

            if (string.IsNullOrWhiteSpace(Largura.ToString()))
                result += "\nInforme a largura do produto";

            if (string.IsNullOrWhiteSpace(Altura.ToString()))
                result += "\nInforme a altura do produto";

            if (string.IsNullOrWhiteSpace(Profundidade.ToString()))
                result += "\nInforme a profundidade do produto";

            return result == "" ? "ok" : result;
        }
    }
}
