using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLEsportes;

namespace Projeto
{
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public DateTime DataMovimento { get; set; }

        public int Quantidade { get; set; }

        public char EntradaSaida { get; set; } // E=entrada S=saída

        public string TipoMovimento { get; set; }

        public string Historico { get; set; }
    }
}
