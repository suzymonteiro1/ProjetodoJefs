using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Clientes
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int Senha { get; set; }

        public string Cpf { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        private ClientesContext _clientesContext = new ClientesContext();

        public string Adicionar()
        {
            var result = Validar();
            if (result == "ok")
                return _clientesContext.Adicionar(this);
            else
                return result;
        }

        public string Validar()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(Nome))
                result += "Informe seu nome.";

            if (string.IsNullOrWhiteSpace(Cpf.ToString()))
                result += "\nInforme o seu cpf.";

            if (string.IsNullOrWhiteSpace(Bairro))
                result += "\nInforme seu bairro.";

            if (string.IsNullOrWhiteSpace(Cidade))
                result += "\nInforme sua cidade.";

            if (string.IsNullOrWhiteSpace(Estado))
                result += "\nInforme seu estado.";

            if (string.IsNullOrWhiteSpace(Email))
                result += "\nInforme seu email";

            if (string.IsNullOrWhiteSpace(Senha.ToString()))
                result += "\nInforme a sua senha";

            return result == "" ? "ok" : result;
        }
    }
}

