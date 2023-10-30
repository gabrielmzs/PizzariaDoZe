using FluentResults;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloCliente {
    public partial class TelaClienteForm : Form {

        private Cliente cliente;
        public event GravarRegistroDelegate<Cliente> onGravarRegistro;
        private Endereco endereco;
        private IRepositorioEndereco RepositorioEndereco;

        public TelaClienteForm(IRepositorioEndereco repositorioEndereco) {
            this.RepositorioEndereco = repositorioEndereco;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);

        }


        public Cliente ObterCliente() {
     
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.NumeroDaCasa = txtNumero.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = endereco;
            

            return cliente;
        }

        public void ConfigurarCliente(Cliente cliente) {

            this.cliente = cliente;

            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone  ;
            txtCpf.Text = cliente.Cpf;
            txtNumero.Text = cliente.NumeroDaCasa;
            txtComplemento.Text = cliente.Complemento ;
            txtEmail.Text = cliente.Email ;

            if(cliente.Endereco !=null) {
            this.endereco = cliente.Endereco;

            txtCep.Text = cliente.Endereco.Cep;


            txtBairro.Text = cliente.Endereco.Bairro;
            txtCidade.Text = cliente.Endereco.Cidade;
            txtEstado.Text = cliente.Endereco.Estado; 
            txtLogradouro.Text = cliente.Endereco.Logradouro;
            txtPais.Text = cliente.Endereco.Pais;

            }



        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            this.cliente = ObterCliente();

            Result resultado = onGravarRegistro(cliente);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                //TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            endereco = RepositorioEndereco.SelecionarPorCep(txtCep.Text);

            if (endereco != null) {
                txtBairro.Text = endereco.Bairro.ToString();
                txtCidade.Text = endereco.Cidade.ToString();
                txtEstado.Text = endereco.Estado.ToString();
                txtLogradouro.Text = endereco.Logradouro.ToString();
                txtPais.Text = endereco.Pais.ToString();
            }
            
            else MessageBox.Show("Endereço não Cadastrado!");
         
        }
    }
}
