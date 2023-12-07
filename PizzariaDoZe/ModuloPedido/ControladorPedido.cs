using PedidoriaDoZe.Aplicacao.ModuloPedio;
using PizzariaDoZe.Aplicacao.ModuloPizza;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloPedido;
using PizzariaDoZe.Dominio.ModuloPizza;
using PizzariaDoZe.Dominio.ModuloSabor;
using PizzariaDoZe.Dominio.ModuloValor;

namespace PizzariaDoZe.ModuloPedido {
    public class ControladorPedido : ControladorBase {

        private IRepositorioPedido repositorioPedido;

        private IRepositorioCliente repositorioCliente;
        private IRepositorioPizza repositorioPizza;
        private IRepositorioBebida repositorioBebida;
        private IRepositorioSabor repositorioSabor;
        private IRepositorioValor repositorioValor;

        private ServicoPedido servicoPedido;
        private ServicoPizza servicoPizza;

        private TabelaPedidoControl tabela;

        public ControladorPedido(IRepositorioPedido repositorioPedido, ServicoPedido servicoPedido, IRepositorioCliente repositorioCliente, IRepositorioPizza repositorioPizza, IRepositorioBebida repositorioBebida, IRepositorioSabor repositorioSabor, IRepositorioValor repositorioValor, ServicoPizza servicoPizza) {
            this.repositorioPedido = repositorioPedido;
            this.servicoPedido = servicoPedido;
            this.repositorioCliente = repositorioCliente;
            this.repositorioPizza = repositorioPizza;
            this.repositorioBebida = repositorioBebida;
            this.repositorioSabor = repositorioSabor;
            this.repositorioValor = repositorioValor;
            this.servicoPizza = servicoPizza;
        }

        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar() {
            //Guid id = tabela.ObtemIdSelecionado();

            //Pedido pedidoSelecionado = repositorioPedido.SelecionarPorId(id);

            //if (pedidoSelecionado == null) {
            //    MessageBox.Show("Selecione um pedido primeiro",
            //    "Edição de Pedidoes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //TelaPedidoForm tela = new TelaPedidoForm();

            //tela.onGravarRegistro += servicoPedido.Editar;

            //tela.ConfigurarPedido(pedidoSelecionado);

            //DialogResult resultado = tela.ShowDialog();

            //if (resultado == DialogResult.OK) {
            //    CarregarPedidoesPizza();
            //}
        }

        public override void Excluir() {
            //Guid id = tabela.ObtemIdSelecionado();

            //Pedido pedidoSelecionado = repositorioPedido.SelecionarPorId(id);

            //if (pedidoSelecionado == null) {
            //    MessageBox.Show("Selecione um pedido primeiro",
            //    "Edição de Pedidoes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            //DialogResult opcaoEscolhida = MessageBox.Show("Deseja realmente excluir o pedido?",
            //   "Exclusão de Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //if (opcaoEscolhida == DialogResult.OK) {
            //    Result resultado = servicoPedido.Excluir(pedidoSelecionado);

            //    if (resultado.IsFailed) {
            //        MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Pedidoes",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        return;
            //    }

            //    CarregarPedidoesPizza();
            //}
        }

        public override void Inserir() {
            TelaPedidoForm tela = new TelaPedidoForm(repositorioCliente, repositorioSabor, repositorioValor,repositorioPizza,servicoPizza, repositorioBebida);

            tela.onGravarRegistro += servicoPedido.Inserir;

            tela.ConfigurarPedido(new Pedido());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarPedidoesPizza();
            }
        }



        private void CarregarPedidoesPizza() {
            List<Pedido> pedidoes = repositorioPedido.SelecionarTodos();

            tabela.AtualizarRegistros(pedidoes);

        }

        public override UserControl ObterListagem() {
            if (tabela == null) {
                tabela = new TabelaPedidoControl();
            }
            CarregarPedidoesPizza();
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Pedidos de Pizzas";
        }
    }
}
