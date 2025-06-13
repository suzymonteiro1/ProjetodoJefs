using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLEsportes;

namespace Projeto
{
    public partial class CadastroCliente : Form
    {

        Clientes _clientes = new Clientes();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _clientes.Id = 0;
            _clientes.Nome = TxtNome.Text;
            _clientes.Email = TxtEmail.Text;
            _clientes.Senha = int.Parse(TxtSenha.Text);
            _clientes.Cpf = (MskCpf.Text);
            _clientes.Bairro = TxtBairro.Text;
            _clientes.Cidade = TxtCidade.Text;
            _clientes.Estado = TxtEstado.Text;

            var result = _clientes.Adicionar();
            if (result == "ok")
                MessageBox.Show("Salvo com sucesso");

            else
                MessageBox.Show("Falha" + result);
        }
    }
}
