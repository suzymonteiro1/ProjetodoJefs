using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class VisualizarContext
    {
        private VisualizarProdutos _VisualizarContext = new VisualizarProdutos();
        public string Mostrar()
        {
            var result = Mostrar();
            if (result == "ok")
                return _VisualizarContext.Mostrar(this);
            else
                return result;
        }
    }
}
