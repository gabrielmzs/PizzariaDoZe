using FluentResults;
using PizzariaDoZe.Aplicacao.ModuloPizza;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Dominio.ModuloPedido;
using PizzariaDoZe.Dominio.ModuloPizza;
using PizzariaDoZe.Dominio.ModuloSabor;
using PizzariaDoZe.Dominio.ModuloValor;
using PizzariaDoZe.Infra.Orm.Migrations;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloPedido {
    public partial class TelaPedidoForm : Form {

        private Pedido pedido;
        public event GravarRegistroDelegate<Pedido> onGravarRegistro;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioSabor repositorioSabor;
        private IRepositorioValor repositorioValor;
        private IRepositorioPizza repositorioPizza;
        private IRepositorioBebida repositorioBebida;

        private ServicoPizza servicoPizza;

        private TamanhoPizzaEnum tamanhoPizza = TamanhoPizzaEnum.Pequena;
        private TipoBordaEnum tipoBordaPizza = TipoBordaEnum.Não;
        private CategoriaPizzaEnum categoriaPizza = CategoriaPizzaEnum.Tradicional;
        private List<Sabor> saboresPizza = new List<Sabor>();
        private decimal valorPizza;


        private List<Pizza> listaPizzasPedido = new List<Pizza>();
        private List<Bebida> listaBebidasPedido = new List<Bebida>();
        private decimal ValorFinal = 0;
        private TipoEntregaEnum tipoEntrega = TipoEntregaEnum.Retirada;


        private Cliente cliente;
        public TelaPedidoForm(IRepositorioCliente repositorioCliente, IRepositorioSabor repositorioSabor, IRepositorioValor repositorioValor, IRepositorioPizza repositorioPizza, ServicoPizza servicoPizza, IRepositorioBebida repositorioBebida) {

            this.repositorioCliente = repositorioCliente;
            this.repositorioSabor = repositorioSabor;
            this.repositorioValor = repositorioValor;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);
            this.repositorioSabor = repositorioSabor;
            this.repositorioValor = repositorioValor;
            this.repositorioPizza = repositorioPizza;
            this.servicoPizza = servicoPizza;
            this.repositorioBebida = repositorioBebida;
            CarregarBebidas();
        }

        private void CarregarBebidas() {

            List<Bebida> listaBebidas = repositorioBebida.SelecionarTodos();

            foreach (var item in listaBebidas) {
                txtBebida.Items.Add(item);
            }

        }

        public void ConfigurarPedido(Pedido pedido) {

            //this.pedido = pedido;
            //txt.Text = sabor.Nome;
            //ConfigurarCategoria(sabor.Categoria);
            //ConfigurarTipo(sabor.Tipo);
            //if (sabor.Ingredientes != null) {
            //    ConfigurarIngredientes(sabor.Ingredientes);
            //}
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {

            List<Cliente> clientes;

            var busca = txtBusca.Text;

            if (rbCPF.Checked) clientes = repositorioCliente.SelecionarPorCPF(busca);
            else if (rbTelefone.Checked) clientes = repositorioCliente.SelecionarPorTelefone(busca);
            else clientes = repositorioCliente.SelecionarListaPorNome(busca);

            listaClientes.Items.Clear();
            foreach (var c in clientes)
                listaClientes.Items.Add(c);


        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            if (listaClientes.Items.Count > 0) cliente = (Cliente)listaClientes.SelectedItems[0];

            if (cliente == null) {
                MessageBox.Show("Um cliente deve ser selecionado!");
                return;
            } else {
                CarregarAbaPizza();
                tabControl.SelectedIndex = 1;
            }

        }

        private void CarregarAbaPizza() {
            txtCliente.Text = cliente.Nome;
            CarregarTamanhos();
            CarregarSabores();
            CarregarBorda();
        }

        private void CarregarBorda() {
            var bordas = Enum.GetValues(typeof(TipoBordaEnum));

            foreach (var b in bordas) {
                listBorda.Items.Add(b);

            }
        }

        private void CarregarSabores() {
            var sabores = repositorioSabor.SelecionarTodos();

            listaSabores1.Items.Clear();
            listaSabores2.Items.Clear();
            listaSabores3.Items.Clear();

            foreach (var s in sabores) {
                if (listaSabores1.Enabled == true) listaSabores1.Items.Add(s);
                if (listaSabores2.Enabled == true) listaSabores2.Items.Add(s);
                if (listaSabores3.Enabled == true) listaSabores3.Items.Add(s);
            }
        }

        private void CarregarTamanhos() {
            var tamanhos = Enum.GetValues(typeof(TamanhoPizzaEnum));

            foreach (var t in tamanhos) {
                listTamanho.Items.Add(t);

            }
        }

        private void listaSabores1_SelectedIndexChanged(object sender, EventArgs e) {
            Sabor sabor = (Sabor)listaSabores1.SelectedItem;

            CalcularValor();

            listaIngredientes1.Items.Clear();
            foreach (var i in sabor.Ingredientes) {
                listaIngredientes1.Items.Add(i);

            }
        }


        private void listaSabores2_SelectedIndexChanged(object sender, EventArgs e) {
            Sabor sabor = (Sabor)listaSabores2.SelectedItem;

            CalcularValor();

            listaIngredientes2.Items.Clear();
            foreach (var i in sabor.Ingredientes) {
                listaIngredientes2.Items.Add(i);

            }
        }

        private void listaSabores3_SelectedIndexChanged(object sender, EventArgs e) {

            Sabor sabor = (Sabor)listaSabores3.SelectedItem;

            CalcularValor();

            listaIngredientes3.Items.Clear();
            foreach (var i in sabor.Ingredientes) {
                listaIngredientes3.Items.Add(i);

            }
        }

        private void listTamanho_SelectedIndexChanged(object sender, EventArgs e) {
            tamanhoPizza = (TamanhoPizzaEnum)listTamanho.SelectedItem;
            CalcularValor();
            HabilitarSabores();
            CarregarSabores();

        }

        private void HabilitarSabores() {
            if (tamanhoPizza == TamanhoPizzaEnum.Pequena) {
                listaSabores2.Enabled = false;
                listaSabores3.Enabled = false;
                listaIngredientes2.Enabled = false;
                listaIngredientes2.Items.Clear();
                listaIngredientes3.Enabled = false;
                listaIngredientes3.Items.Clear();
            } else if (tamanhoPizza == TamanhoPizzaEnum.Média) {
                listaSabores2.Enabled = true;
                listaSabores3.Enabled = false;

                listaIngredientes2.Enabled = true;
                listaIngredientes3.Enabled = false;
                listaIngredientes3.Items.Clear();
            } else {
                listaSabores2.Enabled = true;
                listaSabores3.Enabled = true;
                listaIngredientes2.Enabled = true;
                listaIngredientes3.Enabled = true;
            }
        }

        private void listBorda_SelectedIndexChanged(object sender, EventArgs e) {
            tipoBordaPizza = (TipoBordaEnum)listBorda.SelectedItem;
            CalcularValor();
        }
        private void CalcularValor() {

            if (saboresPizza != null) {
                foreach (var s in saboresPizza) {
                    if (s != null) {

                        if (s.Categoria == CategoriaSaborEnum.Especial) categoriaPizza = CategoriaPizzaEnum.Especial;
                    }
                }
            }

            Valor valor = repositorioValor.SelecionarValorEspecifico(tamanhoPizza, categoriaPizza);

            if (tipoBordaPizza == TipoBordaEnum.Não) valorPizza = valor.ValorPizza;
            else valorPizza = valor.ValorPizza + valor.ValorBorda;

            txtValorPizza.Text = valorPizza.ToString();


        }

        private void btnAdicionarPizza_Click(object sender, EventArgs e) {
            Pizza pizza = ObterPizza();

            servicoPizza.Inserir(pizza);

            listaPizzasPedido.Add(pizza);

            listaPizzas.Items.Add(pizza);

        }

        private Pizza ObterPizza() {
            Pizza pizza = new Pizza();
            pizza.Borda = tipoBordaPizza;
            pizza.Tamanho = tamanhoPizza;
            pizza.Sabores = ObterSabores();
            pizza.Valor = valorPizza;

            return pizza;
        }

        private List<Sabor> ObterSabores() {

            saboresPizza.Clear();

            if (listaSabores1.Enabled = true) saboresPizza.Add((Sabor)listaSabores1.SelectedItem);
            if (listaSabores2.Enabled = true) saboresPizza.Add((Sabor)listaSabores2.SelectedItem);
            if (listaSabores3.Enabled = true) saboresPizza.Add((Sabor)listaSabores3.SelectedItem);


            return saboresPizza;
        }

        private void btnAddBebida_Click(object sender, EventArgs e) {

            Bebida bebida = (Bebida)txtBebida.SelectedItem;

            bebida.Quantidade = (int)txtQuantidade.Value;

            bebida.ValorTotal = bebida.Valor * bebida.Quantidade;

            if (!listaBebidasPedido.Contains(bebida)) listaBebidasPedido.Add(bebida);


            CarregarBebidasTabela();
        }

        private void CarregarBebidasTabela() {
            listBoxBebidas.Items.Clear();

            foreach (var b in listaBebidasPedido) {
                listBoxBebidas.Items.Add(b);
            }
        }

        private void btnEncerrarPedido_Click(object sender, EventArgs e) {

            tabControl.SelectedIndex = 3;
            CarregarInformacoes();

        }

        private void CarregarInformacoes() {
            CarregarCliente();
            CarregarPizzasEPedidos();
            CalcularValorFinal();

        }

        private void CalcularValorFinal() {

            ValorFinal = 0;

            foreach (var b in listaBebidasPedido) {
                ValorFinal += b.ValorTotal;
            }



            foreach (var p in listaPizzasPedido) {
                ValorFinal += p.Valor;
            }

            if (tipoEntrega == TipoEntregaEnum.Entrega && ValorFinal < 100) ValorFinal += 5;

            labelValorPedido.Text = ValorFinal.ToString();
        }

        private void CarregarPizzasEPedidos() {


            lbPizza.Items.Clear();

            foreach (var p in listaPizzasPedido) {
                lbPizza.Items.Add(p);
            }
            listBoxBebidaFinal.Items.Clear();

            foreach (var b in listaBebidasPedido) {
                listBoxBebidaFinal.Items.Add(b);
            }


        }

        private void CarregarCliente() {
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            txtCpf.Text = cliente.Cpf;
            txtNumero.Text = cliente.NumeroDaCasa;
            txtComplemento.Text = cliente.Complemento;

            txtBairro.Text = cliente.Endereco.Bairro;

            txtLogradouro.Text = cliente.Endereco.Logradouro;
        }

        private void rbRetirada_CheckedChanged(object sender, EventArgs e) {
            if (rbRetirada.Checked) tipoEntrega = TipoEntregaEnum.Retirada;
            else tipoEntrega = TipoEntregaEnum.Entrega;
            CalcularValorFinal();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            this.pedido = new Pedido();
            this.pedido = ObterPedido();

            Result resultado = onGravarRegistro(pedido);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                //TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private Pedido ObterPedido() {
            pedido.Bebidas = listaBebidasPedido;
            pedido.Cliente = cliente;
            pedido.Pizzas = listaPizzasPedido;
            pedido.Data = DateTime.Now;
            pedido.ValorTotal = ValorFinal;
            pedido.Entrega = tipoEntrega;
            pedido.Pagamento = FormaPagamentoEnum.Dinheiro;
            pedido.Observacao = " ";
            pedido.Status = StatusPedidoEnum.Confirmado;

            return pedido;
        }
    }
}
