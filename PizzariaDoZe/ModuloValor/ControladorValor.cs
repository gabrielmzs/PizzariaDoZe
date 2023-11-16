using FluentResults;
using PizzariaDoZe.Aplicacao.ModuloBebida;
using PizzariaDoZe.Aplicacao.ModuloValor;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloValor;
using PizzariaDoZe.ModuloBebida;
using PizzariaDoZe.ModuloSabor;

namespace PizzariaDoZe.ModuloValor {
    public class ControladorValor : ControladorBase {

        private IRepositorioValor repositorioValor;

        private ServicoValor servicoValor;

        private TabelaValorControl tabela;

        public ControladorValor(IRepositorioValor repositorioValor, ServicoValor servicoValor) {
            this.repositorioValor = repositorioValor;
            this.servicoValor = servicoValor;
        }

        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar() {
            Guid id = tabela.ObtemIdSelecionado();

            Valor valorSelecionado = repositorioValor.SelecionarPorId(id);

            if (valorSelecionado == null) {
                MessageBox.Show("Selecione um valor primeiro",
                "Edição de Valores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaValorForm tela = new TelaValorForm();

            tela.onGravarRegistro += servicoValor.Editar;

            tela.ConfigurarValor(valorSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarValoresPizza();
            }
        }

        public override void Excluir() {
            Guid id = tabela.ObtemIdSelecionado();

            Valor valorSelecionado = repositorioValor.SelecionarPorId(id);

            if (valorSelecionado == null) {
                MessageBox.Show("Selecione um valor primeiro",
                "Edição de Valores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o valor?",
               "Exclusão de Valor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoValor.Excluir(valorSelecionado);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Valores",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarValoresPizza();
            }
        }

        public override void Inserir() {
            TelaValorForm tela = new TelaValorForm();

            tela.onGravarRegistro += servicoValor.Inserir;

            tela.ConfigurarValor(new Valor());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarValoresPizza();
            }
        }



        private void CarregarValoresPizza() {
            List<Valor> valores = repositorioValor.SelecionarTodos();

            tabela.AtualizarRegistros(valores);

        }

        public override UserControl ObterListagem() {
            if(tabela == null) {
                tabela = new TabelaValorControl();
            }
            CarregarValoresPizza();
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Valores de Pizzas";
        }
    }
}
