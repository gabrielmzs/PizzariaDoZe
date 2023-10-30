using PizzariaDoZe.Aplicacao.ModuloFuncionario;
using PizzariaDoZe.Aplicacao.ModuloFuncionario;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.ModuloFuncionario;
using PizzariaDoZe.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;

namespace PizzariaDoZe.ModuloFuncionario {
    internal class ControladorFuncionario : ControladorBase {

        private TabelaFuncionarioControl tabela;

        private IRepositorioEndereco repositorioEndereco;
        private IRepositorioFuncionario repositorioFuncionario;

        private ServicoFuncionario servicoFuncionario;

        public ControladorFuncionario(IRepositorioEndereco repositorioEndereco, IRepositorioFuncionario repositorioFuncionario, ServicoFuncionario servicoFuncionario) {
            this.repositorioEndereco = repositorioEndereco;
            this.repositorioFuncionario = repositorioFuncionario;
            this.servicoFuncionario = servicoFuncionario;
        }

        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar() {
            Guid id = tabela.ObtemIdSelecionado();

            Funcionario funcionarioSelecionada = repositorioFuncionario.SelecionarPorId(id);

            if (funcionarioSelecionada == null) {
                MessageBox.Show("Selecione um funcionario primeiro",
                "Edição de Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaFuncionarioForm tela = new TelaFuncionarioForm(repositorioEndereco);

            tela.onGravarRegistro += servicoFuncionario.Editar;

            tela.ConfigurarFuncionario(funcionarioSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarFuncionarios();
            }
        }

        public override void Excluir() {
            Guid id = tabela.ObtemIdSelecionado();

            Funcionario funcionarioSelecionada = repositorioFuncionario.SelecionarPorId(id);

            if (funcionarioSelecionada == null) {
                MessageBox.Show("Selecione um funcionario primeiro",
                "Exclusão de Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o funcionario ?",
               "Exclusão de Funcionario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoFuncionario.Excluir(funcionarioSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Funcionarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarFuncionarios();
            }
        }

        public override void Inserir() {
            TelaFuncionarioForm tela = new TelaFuncionarioForm(repositorioEndereco);

            tela.onGravarRegistro += servicoFuncionario.Inserir;

            tela.ConfigurarFuncionario(new Funcionario());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarFuncionarios();
            }
        }

        public override UserControl ObterListagem() {
            if (tabela == null)
                tabela = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabela;
        }

        private void CarregarFuncionarios() {
            List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();

            tabela.AtualizarRegistros(funcionarios);


        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Funcionários";
        }
    }
}
