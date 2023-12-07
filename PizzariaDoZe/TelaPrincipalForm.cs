using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PedidoriaDoZe.Aplicacao.ModuloPedio;
using PedidoriaDoZe.Infra.Orm.ModuloPedido;
using PizzariaDoZe.Aplicacao.ModuloBebida;
using PizzariaDoZe.Aplicacao.ModuloCliente;
using PizzariaDoZe.Aplicacao.ModuloEndereco;
using PizzariaDoZe.Aplicacao.ModuloFuncionario;
using PizzariaDoZe.Aplicacao.ModuloIngrediente;
using PizzariaDoZe.Aplicacao.ModuloPizza;
using PizzariaDoZe.Aplicacao.ModuloSabor;
using PizzariaDoZe.Aplicacao.ModuloValor;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Dominio.ModuloPedido;
using PizzariaDoZe.Dominio.ModuloPizza;
using PizzariaDoZe.Dominio.ModuloSabor;
using PizzariaDoZe.Dominio.ModuloValor;
using PizzariaDoZe.Infra.Orm.Compartilhado;
using PizzariaDoZe.Infra.Orm.ModuloBebida;
using PizzariaDoZe.Infra.Orm.ModuloCliente;
using PizzariaDoZe.Infra.Orm.ModuloEndereco;
using PizzariaDoZe.Infra.Orm.ModuloFuncionario;
using PizzariaDoZe.Infra.Orm.ModuloIngrediente;
using PizzariaDoZe.Infra.Orm.ModuloPizza;
using PizzariaDoZe.Infra.Orm.ModuloSabor;
using PizzariaDoZe.Infra.Orm.ModuloValor;
using PizzariaDoZe.ModuloBebida;
using PizzariaDoZe.ModuloCliente;
using PizzariaDoZe.ModuloEndereco;
using PizzariaDoZe.ModuloFuncionario;
using PizzariaDoZe.ModuloIngrediente;
using PizzariaDoZe.ModuloPedido;
using PizzariaDoZe.ModuloSabor;
using PizzariaDoZe.ModuloValor;
using System.Configuration;
using System.Drawing.Text;
using static PedidoriaDoZe.Dominio.ModuloPedido.IValidadorPedido;
using static PizzariaDoZe.Dominio.ModuloBebida.IValidadorBebida;
using static PizzariaDoZe.Dominio.ModuloCliente.IValidadorCliente;
using static PizzariaDoZe.Dominio.ModuloFuncionario.IValidadorFuncionario;
using static PizzariaDoZe.Dominio.ModuloPizza.IValidadorPizza;
using static PizzariaDoZe.Dominio.ModuloSabor.IValidadorSabor;
using static PizzariaDoZe.Dominio.ModuloValor.IValidadorValor;
using static PizzariaDoZe.Program;

namespace PizzariaDoZe {
    public partial class TelaPrincipalForm : Form {

        private ControladorBase controlador;
        private TelaLoginForm telalogin = new TelaLoginForm();

        private Dictionary<string, ControladorBase> controladores;


        public TelaPrincipalForm() {

            if (telalogin.ShowDialog() == DialogResult.OK) {
                InitializeComponent();
                Instancia = this;
                Funcoes.AjustaResourcesControl(this);

                controladores = new Dictionary<string, ControladorBase>();

                ConfigurarControladores();
            }

        }

        public static TelaPrincipalForm Instancia {
            get;
            private set;
        }

        private void ConfigurarControladores() {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<PizzariaDoZeDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new PizzariaDoZeDbContext(optionsBuilder.Options);

            var migracoesPendentes = dbContext.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0) {
                dbContext.Database.Migrate();
            }

            IRepositorioIngrediente repositorioIngrediente = new RepositorioIngredienteOrm(dbContext);

            ValidadorIngrediente validadorIngrediente = new ValidadorIngrediente();

            ServicoIngrediente servicoIngrediente = new ServicoIngrediente(repositorioIngrediente, validadorIngrediente);

            controladores.Add("ControladorIngrediente", new ControladorIngrediente(repositorioIngrediente, servicoIngrediente));


            IRepositorioEndereco repositorioEndereco = new RepositorioEnderecoOrm(dbContext);

            ValidadorEndereco validadorEndereco = new ValidadorEndereco();

            ServicoEndereco servicoEndereco = new ServicoEndereco(repositorioEndereco, validadorEndereco);

            controladores.Add("ControladorEndereco", new ControladorEndereco(repositorioEndereco, servicoEndereco));


            IRepositorioCliente repositorioCliente = new RepositorioClienteOrm(dbContext);

            ValidadorCliente validadorCliente = new ValidadorCliente();

            ServicoCliente servicoCliente = new ServicoCliente(repositorioCliente, validadorCliente);

            controladores.Add("ControladorCliente", new ControladorCliente(repositorioCliente, servicoCliente, repositorioEndereco));


            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioOrm(dbContext);

            ValidadorFuncionario validadorFuncionario = new ValidadorFuncionario();

            ServicoFuncionario servicoFuncionario = new ServicoFuncionario(repositorioFuncionario, validadorFuncionario);

            controladores.Add("ControladorFuncionario", new ControladorFuncionario(repositorioEndereco, repositorioFuncionario, servicoFuncionario));


            IRepositorioSabor repositorioSabor = new RepositorioSaborOrm(dbContext);

            ValidadorSabor validadorSabor = new ValidadorSabor();

            ServicoSabor servicoSabor = new ServicoSabor(repositorioSabor, validadorSabor);

            controladores.Add("ControladorSabor", new ControladorSabor(repositorioSabor, repositorioIngrediente, servicoSabor));


            IRepositorioBebida repositorioBebida = new RepositorioBebidaOrm(dbContext);

            ValidadorBebida validadorBebida = new ValidadorBebida();

            ServicoBebida servicoBebida = new ServicoBebida(repositorioBebida, validadorBebida);

            controladores.Add("ControladorBebida", new ControladorBebida(repositorioBebida, servicoBebida));


            IRepositorioValor repositorioValor = new RepositorioValorOrm(dbContext);

            ValidadorValor validadorValor = new ValidadorValor();

            ServicoValor servicoValor = new ServicoValor(repositorioValor, validadorValor);

            controladores.Add("ControladorValor", new ControladorValor(repositorioValor, servicoValor));


            IRepositorioPizza repositorioPizza = new RepositorioPizzaOrm(dbContext);

            ValidadorPizza validadorPizza = new ValidadorPizza();

            ServicoPizza servicoPizza = new ServicoPizza(repositorioPizza, validadorPizza);


            IRepositorioPedido repositorioPedido = new RepositorioPedidoOrm(dbContext);

            ValidadorPedido validadorPedido = new ValidadorPedido();

            ServicoPedido servicoPedido = new ServicoPedido(repositorioPedido, validadorPedido);

            controladores.Add("ControladorPedido", new ControladorPedido(repositorioPedido, servicoPedido, repositorioCliente, repositorioPizza, repositorioBebida, repositorioSabor,repositorioValor,servicoPizza));


        }


        /// <summary>
        /// Altera todos os componentes da tela principal
        /// </summary>
        /// 
        private void ConfigurarTelaPrincipal(ControladorBase controlador, string tipo) {

            this.labelTipoCadastro.Text = Properties.Resources.ResourceManager.GetString("labelTipoCadastro" + tipo);

            this.controlador = controlador;

            //ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        /// <summary>
        /// Configura a tabela de acordo com o tipo do cadastro
        /// </summary>
        /// 
        private void ConfigurarListagem(ControladorBase controladorBase) {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void btnEndereco_Click(object sender, EventArgs e) {
            AbrirTela();


            ConfigurarTelaPrincipal(controladores["ControladorEndereco"], "Endereco");
        }
        private void btnFuncionario_Click(object sender, EventArgs e) {
            AbrirTela();

            ConfigurarTelaPrincipal(controladores["ControladorFuncionario"], "Funcionario");

        }

        private void btnInserir_Click(object sender, EventArgs e) {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            controlador.Editar();

        }

        private void btnCliente_Click(object sender, EventArgs e) {
            AbrirTela();

            ConfigurarTelaPrincipal(controladores["ControladorCliente"], "Cliente");
        }



        private void btnIngrediente_Click(object sender, EventArgs e) {
            AbrirTela();
            ConfigurarTelaPrincipal(controladores["ControladorIngrediente"], "Ingrediente");
        }

        private void btnSabor_Click(object sender, EventArgs e) {
            AbrirTela();
            ConfigurarTelaPrincipal(controladores["ControladorSabor"], "Sabor");
        }

        private void btnValor_Click(object sender, EventArgs e) {
            AbrirTela();
            ConfigurarTelaPrincipal(controladores["ControladorValor"], "Valor");
        }

        private void btnBebida_Click(object sender, EventArgs e) {
            AbrirTela();
            ConfigurarTelaPrincipal(controladores["ControladorBebida"], "Bebida");

        }
        private void btnPedido_Click(object sender, EventArgs e) {
            AbrirTela();
            ConfigurarTelaPrincipal(controladores["ControladorPedido"], "Pedido");
        }

        private void btnConfigurar_Click(object sender, EventArgs e) {
            TelaConfiguracaoForm tela = new TelaConfiguracaoForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Controls.Clear();
                InitializeComponent();
                Funcoes.AjustaResourcesControl(this);
            }

        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e) {

            string auxIdiomaRegiao = System.Configuration.ConfigurationManager.AppSettings.Get("IdiomaRegiao");

            DialogResult result = DialogResult.None;

            if (auxIdiomaRegiao == "pt-BR") {
                result = MessageBox.Show("Deseja realmente sair da aplicação?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            } else if (auxIdiomaRegiao == "en-US") {
                result = MessageBox.Show("Do you really want to quit the application??", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            } else {
                result = MessageBox.Show("¿Realmente quieres salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }

            if (result == DialogResult.Yes) {

            } else if (result == DialogResult.Cancel) {
                e.Cancel = true;
            } else {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }



        private void contextMenuStripPrincipal_Opening(object sender, System.ComponentModel.CancelEventArgs e) {

        }

        private void AbrirTela() {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIconSystemTray_DoubleClick(object sender, EventArgs e) {
            AbrirTela();
        }

        private void TelaPrincipalForm_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            } else if (FormWindowState.Normal == this.WindowState) {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Desenvolvido por Gabriel Menezes", "Pizzaria do Zé - V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            controlador.Excluir();
        }






        //private void ConfigurarToolTips(ControladorBase controlador) {

        //    btnInserir.ToolTipText = controlador.ToolTipInserir;
        //    btnEditar.ToolTipText = controlador.ToolTipEditar;
        //    btnExcluir.ToolTipText = controlador.ToolTipExcluir;

        //}
    }
}