using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.ModuloSabor;

namespace PizzariaDoZe.ModuloValor {
    public class ControladorValor : ControladorBase {

        private TabelaValorControl tabela;
        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar() {
            throw new NotImplementedException();
        }

        public override void Excluir() {
            throw new NotImplementedException();
        }

        public override void Inserir() {
            TelaValorForm tela = new TelaValorForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                MessageBox.Show("Valor de Pizza Cadastrado com sucesso!");
            };
        }

        public override UserControl ObterListagem() {
            if(tabela == null) {
                tabela = new TabelaValorControl();
            }   
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Valores de Pizzas";
        }
    }
}
