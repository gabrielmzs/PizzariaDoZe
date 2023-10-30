using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentResults;

namespace PizzariaDoZe.ModuloFuncionario {
    public partial class TelaFuncionarioForm : Form {

        private Funcionario funcionario;
        private Endereco endereco;
        public event GravarRegistroDelegate<Funcionario> onGravarRegistro;
        private IRepositorioEndereco RepositorioEndereco;
        public TelaFuncionarioForm(IRepositorioEndereco repositorioEndereco) {
            this.RepositorioEndereco = repositorioEndereco;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);
        }

        public Funcionario ObterFuncionario() {

            funcionario.Nome = txtNome.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.NumeroDaCasa = txtNumero.Text;
            funcionario.Complemento = txtComplemento.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Matricula= txtMatricula.Text;
            funcionario.Senha = Funcoes.Sha256Hash(txtSenha.Text);

            funcionario.GrupoFuncionario = ObterGrupo();

            funcionario.Endereco = endereco;


            return funcionario;
        }

        private GrupoFuncionarioEnum ObterGrupo() {
            if (rbAdmin.Checked) return GrupoFuncionarioEnum.Administrativo;
            else if (rbAtendente.Checked) return GrupoFuncionarioEnum.Atendente;
            else return GrupoFuncionarioEnum.Entregador;
        }

        private void SelecionarGrupo(GrupoFuncionarioEnum tipo) {
            if(tipo == GrupoFuncionarioEnum.Administrativo) rbAdmin.Checked = true;
            else if (tipo == GrupoFuncionarioEnum.Atendente) rbAtendente.Checked= true;
            else rbEntregador.Checked = true;
        }

        public void ConfigurarFuncionario(Funcionario funcionario) {

            this.funcionario = funcionario;

            txtNome.Text = funcionario.Nome;
            txtTelefone.Text = funcionario.Telefone;
            txtCpf.Text = funcionario.Cpf;
            txtNumero.Text = funcionario.NumeroDaCasa;
            txtComplemento.Text = funcionario.Complemento;
            txtEmail.Text = funcionario.Email;
            txtMatricula.Text= funcionario.Matricula;
            txtSenha.Text= funcionario.Senha;
            SelecionarGrupo(funcionario.GrupoFuncionario);


            if (funcionario.Endereco != null) {
                this.endereco = funcionario.Endereco;

                txtCep.Text = funcionario.Endereco.Cep;


                txtBairro.Text = funcionario.Endereco.Bairro;
                txtCidade.Text = funcionario.Endereco.Cidade;
                txtEstado.Text = funcionario.Endereco.Estado;
                txtLogradouro.Text = funcionario.Endereco.Logradouro;
                txtPais.Text = funcionario.Endereco.Pais;

            }



        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            this.funcionario = ObterFuncionario();

            Result resultado = onGravarRegistro(funcionario);

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
            } else MessageBox.Show("Endereço não Cadastrado!");

        }








        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if(rbAdmin.Checked) {
                txtCnh.Enabled = false;
                txtObs.Enabled = false;
                txtValidade.Enabled = false;
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (rbAtendente.Checked) {
                txtCnh.Enabled = false;
                txtObs.Enabled = false;
                txtValidade.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            if (rbEntregador.Checked) {
                txtCnh.Enabled = true;
                txtObs.Enabled = true;
                txtValidade.Enabled = true;
            }
        }
    }
}
