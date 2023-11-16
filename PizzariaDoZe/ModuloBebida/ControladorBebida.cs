using FluentResults;
using PizzariaDoZe.Aplicacao.ModuloBebida;
using PizzariaDoZe.Aplicacao.ModuloFuncionario;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.ModuloFuncionario;

namespace PizzariaDoZe.ModuloBebida {
    public class ControladorBebida : ControladorBase {

        private TabelaBebidaControl tabela;

        private IRepositorioBebida repositorioBebida;

        private ServicoBebida servicoBebida;

        public ControladorBebida(IRepositorioBebida repositorioBebida, ServicoBebida servicoBebida) {
            this.repositorioBebida = repositorioBebida;
            this.servicoBebida = servicoBebida;
        }

        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();
        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar()  {
            Guid id = tabela.ObtemIdSelecionado();

            Bebida bebidaSelecionada = repositorioBebida.SelecionarPorId(id);

            if (bebidaSelecionada == null) {
                MessageBox.Show("Selecione uma bebida primeiro",
                "Edição de Bebidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaBebidaForm tela = new TelaBebidaForm();

            tela.onGravarRegistro += servicoBebida.Editar;

            tela.ConfigurarBebida(bebidaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarBebidas();
            }
        }

        public override void Excluir() {
            Guid id = tabela.ObtemIdSelecionado();

            Bebida bebidaSelecionada = repositorioBebida.SelecionarPorId(id);

            if (bebidaSelecionada == null) {
                MessageBox.Show("Selecione uma bebida primeiro",
                "Edição de Bebidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir a bebida?",
               "Exclusão de Bebida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoBebida.Excluir(bebidaSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Bebidas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarBebidas();
            }
        }

        public override void Inserir() {
            TelaBebidaForm tela = new TelaBebidaForm();

            tela.onGravarRegistro += servicoBebida.Inserir;

            tela.ConfigurarBebida(new Bebida());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarBebidas();
            }
        }



        private void CarregarBebidas() {
            List<Bebida> bebidas = repositorioBebida.SelecionarTodos();

            tabela.AtualizarRegistros(bebidas);

        }

        public override UserControl ObterListagem() {
            if(tabela== null) {
                tabela = new TabelaBebidaControl();
            }
            CarregarBebidas();
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Bebidas";
        }
    }
}

