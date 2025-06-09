using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
