using FluentResults;
using PizzariaDoZe.Aplicacao.ModuloIngrediente;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloIngrediente;

namespace PizzariaDoZe.ModuloIngrediente {
    public class ControladorIngrediente : ControladorBase {

        private TabelaIngredienteControl tabelaIngrediente;
        private IRepositorioIngrediente repositorioIngrediente;
        private ServicoIngrediente servicoIngrediente;

        public ControladorIngrediente(IRepositorioIngrediente repositorioIngrediente, ServicoIngrediente servicoIngrediente) {
            this.repositorioIngrediente = repositorioIngrediente;
            this.servicoIngrediente = servicoIngrediente;
        }

        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Inserir() {
            TelaIngredienteForm tela = new TelaIngredienteForm();

            tela.onGravarRegistro += servicoIngrediente.Inserir;

            tela.ConfigurarIngrediente(new Ingrediente());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarIngredientes();
            }
        }

        public override void Editar() {

            Guid id = tabelaIngrediente.ObtemIdSelecionado();

            Ingrediente ingredienteSelecionada = repositorioIngrediente.SelecionarPorId(id);

            if (ingredienteSelecionada == null) {
                MessageBox.Show("Selecione uma ingrediente primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaIngredienteForm tela = new TelaIngredienteForm();

            tela.onGravarRegistro += servicoIngrediente.Editar;

            tela.ConfigurarIngrediente(ingredienteSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarIngredientes();
            }
        }

        public override void Excluir() {

            Guid id = tabelaIngrediente.ObtemIdSelecionado();

            Ingrediente ingredienteSelecionada = repositorioIngrediente.SelecionarPorId(id);

            if (ingredienteSelecionada == null) {
                MessageBox.Show("Selecione uma ingrediente primeiro",
                "Exclusão de Ingredientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir a ingrediente?",
               "Exclusão de Ingredientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoIngrediente.Excluir(ingredienteSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Ingredientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarIngredientes();
            }
        }

        public override UserControl ObterListagem() {
            if (tabelaIngrediente == null) {
                tabelaIngrediente = new TabelaIngredienteControl();
                
            }
            CarregarIngredientes();
            return tabelaIngrediente;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Ingredientes";
        }

        private void CarregarIngredientes() {
            List<Ingrediente> ingredientes = repositorioIngrediente.SelecionarTodos();

            tabelaIngrediente.AtualizarRegistros(ingredientes);

            //mensagemRodape = string.Format("Visualizando {0} ingrediente{1}", ingredientes.Count, ingredientes.Count == 1 ? "" : "s");

            //TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }
    }
}
