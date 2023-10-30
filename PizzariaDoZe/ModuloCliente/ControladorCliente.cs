using FluentResults;
using PizzariaDoZe.Aplicacao.ModuloCliente;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloEndereco;

namespace PizzariaDoZe.ModuloCliente {
    public class ControladorCliente : ControladorBase {

        private TabelaClienteControl tabela;

        private IRepositorioCliente repositorioCliente;
        private IRepositorioEndereco repositorioEndereco;
      
        private ServicoCliente servicoCliente;
        public ControladorCliente(IRepositorioCliente repositorioCliente, ServicoCliente servicoCliente,IRepositorioEndereco repositorioEndereco) {
            this.repositorioCliente = repositorioCliente;
            this.servicoCliente = servicoCliente;
            this.repositorioEndereco = repositorioEndereco;
        }
        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar() {
            Guid id = tabela.ObtemIdSelecionado();

            Cliente clienteSelecionada = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionada == null) {
                MessageBox.Show("Selecione um cliente primeiro",
                "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaClienteForm tela = new TelaClienteForm(repositorioEndereco);

            tela.onGravarRegistro += servicoCliente.Editar;

            tela.ConfigurarCliente(clienteSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarClientes();
            }
        }

        public override void Excluir() {
            Guid id = tabela.ObtemIdSelecionado();

            Cliente clienteSelecionada = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionada == null) {
                MessageBox.Show("Selecione um cliente primeiro",
                "Exclusão de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o cliente ?",
               "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                Result resultado = servicoCliente.Excluir(clienteSelecionada);

                if (resultado.IsFailed) {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Clientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CarregarClientes();
            }
        }

        public override void Inserir() {
            TelaClienteForm tela = new TelaClienteForm(repositorioEndereco);

            tela.onGravarRegistro += servicoCliente.Inserir;

            tela.ConfigurarCliente(new Cliente());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarClientes();
            }
        }

        public override UserControl ObterListagem() {
            if (tabela == null)
                tabela = new TabelaClienteControl();

            CarregarClientes();

            return tabela;
        }

        private void CarregarClientes() {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabela.AtualizarRegistros(clientes);

            
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Clientes";
        }
    }
}
