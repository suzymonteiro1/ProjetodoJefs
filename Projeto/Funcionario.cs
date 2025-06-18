using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public DateTime DataContratacao { get; set; }    
        public int Senha { get; set; }
        public string Cpf { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        private FuncionarioContext _funcionarioContext = new FuncionarioContext();

        public string Adicionar()
        {
            var result = Validar();
            if (result == "ok")
                return _funcionarioContext.Adicionar(this);
            else
                return result;
        }

        public string Validar()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(Nome))
                result += "Informe o nome do funcionario.";

            if (string.IsNullOrWhiteSpace(Cargo))
                result += "Informe o cargo do funcionario.";

            if (string.IsNullOrWhiteSpace(DataContratacao.ToString()))
                result += "Informe a data que o funcionario foi contratado";

            if (string.IsNullOrWhiteSpace(Cpf.ToString()))
                result += "\nInforme o cpf do funcionario.";

            if (string.IsNullOrWhiteSpace(Bairro))
                result += "\nInforme o bairro do funcionario.";

            if (string.IsNullOrWhiteSpace(Cidade))
                result += "\nInforme a cidade do funcionario.";

            if (string.IsNullOrWhiteSpace(Estado))
                result += "\nInforme o estado do funcionario.";

            if (string.IsNullOrWhiteSpace(Email))
                result += "\nInforme o email do funcionrio";

            if (string.IsNullOrWhiteSpace(Senha.ToString()))
                result += "\nInforme a senha do funcionario";

            return result == "" ? "ok" : result;
        }
    }

}


