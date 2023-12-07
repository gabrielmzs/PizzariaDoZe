namespace PizzariaDoZe.ModuloPedido {
    partial class TelaPedidoForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabControl = new TabControl();
            tabCliente = new TabPage();
            listaClientes = new ListBox();
            btnIniciar = new Button();
            btnPesquisar = new Button();
            txtBusca = new TextBox();
            labelFiltro = new GroupBox();
            rbNome = new RadioButton();
            rbTelefone = new RadioButton();
            rbCPF = new RadioButton();
            tabPizza = new TabPage();
            listaPizzas = new ListBox();
            groupBoxPizza = new GroupBox();
            listaIngredientes3 = new CheckedListBox();
            listaIngredientes2 = new CheckedListBox();
            listaIngredientes1 = new CheckedListBox();
            labelValorDaPizza = new Label();
            btnAdicionarPizza = new Button();
            txtValorPizza = new Label();
            labelBorda = new Label();
            listBorda = new ListBox();
            labelRemoverIngredientes = new Label();
            listaSabores3 = new ListBox();
            listaSabores2 = new ListBox();
            listaSabores1 = new ListBox();
            labelTamanho = new Label();
            listTamanho = new ListBox();
            txtCliente = new TextBox();
            labelCliente = new Label();
            tabBebida = new TabPage();
            boxBebidas = new GroupBox();
            btnEncerrarPedido = new Button();
            labelListaBebidas = new Label();
            labelQuantidade = new Label();
            labelBebida = new Label();
            txtQuantidade = new NumericUpDown();
            listBoxBebidas = new ListBox();
            txtBebida = new ComboBox();
            btnAddBebida = new Button();
            tabFinalizar = new TabPage();
            btnSalvar = new Button();
            lbPizza = new ListBox();
            labelValorPedido = new Label();
            labelValorFinal = new Label();
            labelBebidas = new Label();
            listBoxBebidaFinal = new ListBox();
            labelPizzas = new Label();
            labelComplemento = new Label();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            labelNumero = new Label();
            txtTelefone = new MaskedTextBox();
            labelTelefone = new Label();
            txtCpf = new MaskedTextBox();
            labelCPF = new Label();
            txtNome = new TextBox();
            labelNome = new Label();
            labelBairro = new Label();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            labelLogradouro = new Label();
            labelPagamento = new GroupBox();
            rbPix = new RadioButton();
            rbCartao = new RadioButton();
            rbDinheiro = new RadioButton();
            labelEntrega = new GroupBox();
            rbRetirada = new RadioButton();
            rbEntrega = new RadioButton();
            btnRemover = new Button();
            btnRemoverBebida = new Button();
            tabControl.SuspendLayout();
            tabCliente.SuspendLayout();
            labelFiltro.SuspendLayout();
            tabPizza.SuspendLayout();
            groupBoxPizza.SuspendLayout();
            tabBebida.SuspendLayout();
            boxBebidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            tabFinalizar.SuspendLayout();
            labelPagamento.SuspendLayout();
            labelEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCliente);
            tabControl.Controls.Add(tabPizza);
            tabControl.Controls.Add(tabBebida);
            tabControl.Controls.Add(tabFinalizar);
            tabControl.Location = new Point(12, 21);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1200, 769);
            tabControl.TabIndex = 0;
            // 
            // tabCliente
            // 
            tabCliente.BackColor = Color.Black;
            tabCliente.Controls.Add(listaClientes);
            tabCliente.Controls.Add(btnIniciar);
            tabCliente.Controls.Add(btnPesquisar);
            tabCliente.Controls.Add(txtBusca);
            tabCliente.Controls.Add(labelFiltro);
            tabCliente.Location = new Point(4, 24);
            tabCliente.Name = "tabCliente";
            tabCliente.Padding = new Padding(3);
            tabCliente.Size = new Size(1192, 741);
            tabCliente.TabIndex = 0;
            tabCliente.Text = "Cliente";
            // 
            // listaClientes
            // 
            listaClientes.FormattingEnabled = true;
            listaClientes.ItemHeight = 15;
            listaClientes.Location = new Point(41, 177);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(1117, 544);
            listaClientes.TabIndex = 4;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(1052, 48);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(106, 66);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar Pedido";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(754, 48);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(85, 66);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(417, 73);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(315, 23);
            txtBusca.TabIndex = 1;
            // 
            // labelFiltro
            // 
            labelFiltro.Controls.Add(rbNome);
            labelFiltro.Controls.Add(rbTelefone);
            labelFiltro.Controls.Add(rbCPF);
            labelFiltro.ForeColor = SystemColors.Control;
            labelFiltro.Location = new Point(41, 35);
            labelFiltro.Name = "labelFiltro";
            labelFiltro.Size = new Size(276, 79);
            labelFiltro.TabIndex = 0;
            labelFiltro.TabStop = false;
            labelFiltro.Text = "Selecione um Filtro:";
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Checked = true;
            rbNome.ForeColor = SystemColors.Control;
            rbNome.Location = new Point(146, 35);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(58, 19);
            rbNome.TabIndex = 3;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            // 
            // rbTelefone
            // 
            rbTelefone.AutoSize = true;
            rbTelefone.ForeColor = SystemColors.Control;
            rbTelefone.Location = new Point(71, 35);
            rbTelefone.Name = "rbTelefone";
            rbTelefone.Size = new Size(69, 19);
            rbTelefone.TabIndex = 2;
            rbTelefone.Text = "Telefone";
            rbTelefone.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            rbCPF.AutoSize = true;
            rbCPF.ForeColor = SystemColors.Control;
            rbCPF.Location = new Point(19, 35);
            rbCPF.Name = "rbCPF";
            rbCPF.Size = new Size(46, 19);
            rbCPF.TabIndex = 1;
            rbCPF.Text = "CPF";
            rbCPF.UseVisualStyleBackColor = true;
            // 
            // tabPizza
            // 
            tabPizza.BackColor = Color.Black;
            tabPizza.Controls.Add(btnRemover);
            tabPizza.Controls.Add(listaPizzas);
            tabPizza.Controls.Add(groupBoxPizza);
            tabPizza.Controls.Add(txtCliente);
            tabPizza.Controls.Add(labelCliente);
            tabPizza.ForeColor = SystemColors.Control;
            tabPizza.Location = new Point(4, 24);
            tabPizza.Name = "tabPizza";
            tabPizza.Padding = new Padding(3);
            tabPizza.Size = new Size(1192, 741);
            tabPizza.TabIndex = 1;
            tabPizza.Text = "Pizza";
            // 
            // listaPizzas
            // 
            listaPizzas.FormattingEnabled = true;
            listaPizzas.ItemHeight = 15;
            listaPizzas.Location = new Point(37, 530);
            listaPizzas.Name = "listaPizzas";
            listaPizzas.Size = new Size(915, 184);
            listaPizzas.TabIndex = 3;
            // 
            // groupBoxPizza
            // 
            groupBoxPizza.BackColor = Color.Black;
            groupBoxPizza.Controls.Add(listaIngredientes3);
            groupBoxPizza.Controls.Add(listaIngredientes2);
            groupBoxPizza.Controls.Add(listaIngredientes1);
            groupBoxPizza.Controls.Add(labelValorDaPizza);
            groupBoxPizza.Controls.Add(btnAdicionarPizza);
            groupBoxPizza.Controls.Add(txtValorPizza);
            groupBoxPizza.Controls.Add(labelBorda);
            groupBoxPizza.Controls.Add(listBorda);
            groupBoxPizza.Controls.Add(labelRemoverIngredientes);
            groupBoxPizza.Controls.Add(listaSabores3);
            groupBoxPizza.Controls.Add(listaSabores2);
            groupBoxPizza.Controls.Add(listaSabores1);
            groupBoxPizza.Controls.Add(labelTamanho);
            groupBoxPizza.Controls.Add(listTamanho);
            groupBoxPizza.ForeColor = SystemColors.Control;
            groupBoxPizza.Location = new Point(37, 76);
            groupBoxPizza.Name = "groupBoxPizza";
            groupBoxPizza.Size = new Size(1130, 439);
            groupBoxPizza.TabIndex = 2;
            groupBoxPizza.TabStop = false;
            groupBoxPizza.Text = "Adicionar Pizza";
            // 
            // listaIngredientes3
            // 
            listaIngredientes3.Enabled = false;
            listaIngredientes3.FormattingEnabled = true;
            listaIngredientes3.Location = new Point(561, 285);
            listaIngredientes3.Name = "listaIngredientes3";
            listaIngredientes3.Size = new Size(164, 130);
            listaIngredientes3.TabIndex = 17;
            // 
            // listaIngredientes2
            // 
            listaIngredientes2.Enabled = false;
            listaIngredientes2.FormattingEnabled = true;
            listaIngredientes2.Location = new Point(363, 285);
            listaIngredientes2.Name = "listaIngredientes2";
            listaIngredientes2.Size = new Size(164, 130);
            listaIngredientes2.TabIndex = 16;
            // 
            // listaIngredientes1
            // 
            listaIngredientes1.FormattingEnabled = true;
            listaIngredientes1.Location = new Point(166, 285);
            listaIngredientes1.Name = "listaIngredientes1";
            listaIngredientes1.Size = new Size(164, 130);
            listaIngredientes1.TabIndex = 15;
            // 
            // labelValorDaPizza
            // 
            labelValorDaPizza.AutoSize = true;
            labelValorDaPizza.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorDaPizza.Location = new Point(788, 251);
            labelValorDaPizza.Name = "labelValorDaPizza";
            labelValorDaPizza.Size = new Size(170, 28);
            labelValorDaPizza.TabIndex = 14;
            labelValorDaPizza.Text = "Valor da Pizza: R$ ";
            // 
            // btnAdicionarPizza
            // 
            btnAdicionarPizza.ForeColor = SystemColors.ControlText;
            btnAdicionarPizza.Location = new Point(864, 335);
            btnAdicionarPizza.Name = "btnAdicionarPizza";
            btnAdicionarPizza.Size = new Size(150, 48);
            btnAdicionarPizza.TabIndex = 13;
            btnAdicionarPizza.Text = "Adicionar Pizza";
            btnAdicionarPizza.UseVisualStyleBackColor = true;
            btnAdicionarPizza.Click += btnAdicionarPizza_Click;
            // 
            // txtValorPizza
            // 
            txtValorPizza.AutoSize = true;
            txtValorPizza.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPizza.Location = new Point(979, 251);
            txtValorPizza.Name = "txtValorPizza";
            txtValorPizza.Size = new Size(60, 28);
            txtValorPizza.TabIndex = 12;
            txtValorPizza.Text = "00,00";
            // 
            // labelBorda
            // 
            labelBorda.AutoSize = true;
            labelBorda.Location = new Point(917, 45);
            labelBorda.Name = "labelBorda";
            labelBorda.Size = new Size(41, 15);
            labelBorda.TabIndex = 10;
            labelBorda.Text = "Borda:";
            // 
            // listBorda
            // 
            listBorda.FormattingEnabled = true;
            listBorda.ItemHeight = 15;
            listBorda.Location = new Point(885, 72);
            listBorda.Name = "listBorda";
            listBorda.Size = new Size(115, 94);
            listBorda.TabIndex = 9;
            listBorda.SelectedIndexChanged += listBorda_SelectedIndexChanged;
            // 
            // labelRemoverIngredientes
            // 
            labelRemoverIngredientes.AutoSize = true;
            labelRemoverIngredientes.Location = new Point(166, 262);
            labelRemoverIngredientes.Name = "labelRemoverIngredientes";
            labelRemoverIngredientes.Size = new Size(216, 15);
            labelRemoverIngredientes.TabIndex = 8;
            labelRemoverIngredientes.Text = "Selecione os ingredientes para remover:";
            // 
            // listaSabores3
            // 
            listaSabores3.Enabled = false;
            listaSabores3.FormattingEnabled = true;
            listaSabores3.ItemHeight = 15;
            listaSabores3.Location = new Point(561, 45);
            listaSabores3.Name = "listaSabores3";
            listaSabores3.Size = new Size(164, 184);
            listaSabores3.TabIndex = 4;
            listaSabores3.SelectedIndexChanged += listaSabores3_SelectedIndexChanged;
            // 
            // listaSabores2
            // 
            listaSabores2.Enabled = false;
            listaSabores2.FormattingEnabled = true;
            listaSabores2.ItemHeight = 15;
            listaSabores2.Location = new Point(363, 45);
            listaSabores2.Name = "listaSabores2";
            listaSabores2.Size = new Size(164, 184);
            listaSabores2.TabIndex = 3;
            listaSabores2.SelectedIndexChanged += listaSabores2_SelectedIndexChanged;
            // 
            // listaSabores1
            // 
            listaSabores1.FormattingEnabled = true;
            listaSabores1.ItemHeight = 15;
            listaSabores1.Location = new Point(166, 45);
            listaSabores1.Name = "listaSabores1";
            listaSabores1.Size = new Size(164, 184);
            listaSabores1.TabIndex = 2;
            listaSabores1.SelectedIndexChanged += listaSabores1_SelectedIndexChanged;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Location = new Point(29, 127);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(62, 15);
            labelTamanho.TabIndex = 1;
            labelTamanho.Text = "Tamanho: ";
            // 
            // listTamanho
            // 
            listTamanho.FormattingEnabled = true;
            listTamanho.ItemHeight = 15;
            listTamanho.Location = new Point(19, 159);
            listTamanho.Name = "listTamanho";
            listTamanho.Size = new Size(83, 109);
            listTamanho.TabIndex = 0;
            listTamanho.SelectedIndexChanged += listTamanho_SelectedIndexChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(104, 23);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(872, 23);
            txtCliente.TabIndex = 1;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(37, 26);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(50, 15);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente: ";
            // 
            // tabBebida
            // 
            tabBebida.BackColor = SystemColors.ControlText;
            tabBebida.Controls.Add(boxBebidas);
            tabBebida.Location = new Point(4, 24);
            tabBebida.Name = "tabBebida";
            tabBebida.Padding = new Padding(3);
            tabBebida.Size = new Size(1192, 741);
            tabBebida.TabIndex = 2;
            tabBebida.Text = "Bebidas";
            // 
            // boxBebidas
            // 
            boxBebidas.BackColor = SystemColors.ControlText;
            boxBebidas.Controls.Add(btnRemoverBebida);
            boxBebidas.Controls.Add(btnEncerrarPedido);
            boxBebidas.Controls.Add(labelListaBebidas);
            boxBebidas.Controls.Add(labelQuantidade);
            boxBebidas.Controls.Add(labelBebida);
            boxBebidas.Controls.Add(txtQuantidade);
            boxBebidas.Controls.Add(listBoxBebidas);
            boxBebidas.Controls.Add(txtBebida);
            boxBebidas.Controls.Add(btnAddBebida);
            boxBebidas.ForeColor = SystemColors.Control;
            boxBebidas.Location = new Point(21, 22);
            boxBebidas.Name = "boxBebidas";
            boxBebidas.Size = new Size(1142, 692);
            boxBebidas.TabIndex = 0;
            boxBebidas.TabStop = false;
            boxBebidas.Text = "Ajuste a quantidade das Bebidas";
            // 
            // btnEncerrarPedido
            // 
            btnEncerrarPedido.ForeColor = SystemColors.MenuText;
            btnEncerrarPedido.Location = new Point(843, 611);
            btnEncerrarPedido.Name = "btnEncerrarPedido";
            btnEncerrarPedido.Size = new Size(259, 62);
            btnEncerrarPedido.TabIndex = 8;
            btnEncerrarPedido.Text = "Encerrar Pedido";
            btnEncerrarPedido.UseVisualStyleBackColor = true;
            btnEncerrarPedido.Click += btnEncerrarPedido_Click;
            // 
            // labelListaBebidas
            // 
            labelListaBebidas.AutoSize = true;
            labelListaBebidas.ForeColor = SystemColors.Control;
            labelListaBebidas.Location = new Point(32, 125);
            labelListaBebidas.Name = "labelListaBebidas";
            labelListaBebidas.Size = new Size(94, 15);
            labelListaBebidas.TabIndex = 7;
            labelListaBebidas.Text = "Lista de Bebidas:";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.ForeColor = SystemColors.Control;
            labelQuantidade.Location = new Point(581, 55);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(75, 15);
            labelQuantidade.TabIndex = 6;
            labelQuantidade.Text = "Quantidade: ";
            // 
            // labelBebida
            // 
            labelBebida.AutoSize = true;
            labelBebida.ForeColor = SystemColors.Control;
            labelBebida.Location = new Point(32, 55);
            labelBebida.Name = "labelBebida";
            labelBebida.Size = new Size(49, 15);
            labelBebida.TabIndex = 5;
            labelBebida.Text = "Bebida: ";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(693, 52);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(89, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // listBoxBebidas
            // 
            listBoxBebidas.FormattingEnabled = true;
            listBoxBebidas.ItemHeight = 15;
            listBoxBebidas.Location = new Point(32, 161);
            listBoxBebidas.Name = "listBoxBebidas";
            listBoxBebidas.Size = new Size(750, 454);
            listBoxBebidas.TabIndex = 3;
            // 
            // txtBebida
            // 
            txtBebida.FormattingEnabled = true;
            txtBebida.Location = new Point(81, 52);
            txtBebida.Name = "txtBebida";
            txtBebida.Size = new Size(448, 23);
            txtBebida.TabIndex = 2;
            // 
            // btnAddBebida
            // 
            btnAddBebida.ForeColor = SystemColors.MenuText;
            btnAddBebida.Location = new Point(843, 31);
            btnAddBebida.Name = "btnAddBebida";
            btnAddBebida.Size = new Size(259, 62);
            btnAddBebida.TabIndex = 1;
            btnAddBebida.Text = "Adicionar Bebida";
            btnAddBebida.UseVisualStyleBackColor = true;
            btnAddBebida.Click += btnAddBebida_Click;
            // 
            // tabFinalizar
            // 
            tabFinalizar.BackColor = SystemColors.ControlText;
            tabFinalizar.Controls.Add(btnSalvar);
            tabFinalizar.Controls.Add(lbPizza);
            tabFinalizar.Controls.Add(labelValorPedido);
            tabFinalizar.Controls.Add(labelValorFinal);
            tabFinalizar.Controls.Add(labelBebidas);
            tabFinalizar.Controls.Add(listBoxBebidaFinal);
            tabFinalizar.Controls.Add(labelPizzas);
            tabFinalizar.Controls.Add(labelComplemento);
            tabFinalizar.Controls.Add(txtComplemento);
            tabFinalizar.Controls.Add(txtNumero);
            tabFinalizar.Controls.Add(labelNumero);
            tabFinalizar.Controls.Add(txtTelefone);
            tabFinalizar.Controls.Add(labelTelefone);
            tabFinalizar.Controls.Add(txtCpf);
            tabFinalizar.Controls.Add(labelCPF);
            tabFinalizar.Controls.Add(txtNome);
            tabFinalizar.Controls.Add(labelNome);
            tabFinalizar.Controls.Add(labelBairro);
            tabFinalizar.Controls.Add(txtBairro);
            tabFinalizar.Controls.Add(txtLogradouro);
            tabFinalizar.Controls.Add(labelLogradouro);
            tabFinalizar.Controls.Add(labelPagamento);
            tabFinalizar.Controls.Add(labelEntrega);
            tabFinalizar.ForeColor = SystemColors.ControlText;
            tabFinalizar.Location = new Point(4, 24);
            tabFinalizar.Name = "tabFinalizar";
            tabFinalizar.Padding = new Padding(3);
            tabFinalizar.Size = new Size(1192, 741);
            tabFinalizar.TabIndex = 3;
            tabFinalizar.Text = "Finalizar Pedido";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(1053, 659);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 60);
            btnSalvar.TabIndex = 112;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lbPizza
            // 
            lbPizza.FormattingEnabled = true;
            lbPizza.ItemHeight = 15;
            lbPizza.Location = new Point(26, 213);
            lbPizza.Name = "lbPizza";
            lbPizza.Size = new Size(1121, 124);
            lbPizza.TabIndex = 111;
            // 
            // labelValorPedido
            // 
            labelValorPedido.AutoSize = true;
            labelValorPedido.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorPedido.ForeColor = SystemColors.Control;
            labelValorPedido.Location = new Point(368, 659);
            labelValorPedido.Name = "labelValorPedido";
            labelValorPedido.Size = new Size(104, 37);
            labelValorPedido.TabIndex = 110;
            labelValorPedido.Text = "000,00";
            // 
            // labelValorFinal
            // 
            labelValorFinal.AutoSize = true;
            labelValorFinal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorFinal.ForeColor = SystemColors.Control;
            labelValorFinal.Location = new Point(26, 659);
            labelValorFinal.Name = "labelValorFinal";
            labelValorFinal.Size = new Size(349, 37);
            labelValorFinal.TabIndex = 109;
            labelValorFinal.Text = "Valor Total do Pedido: R$ ";
            // 
            // labelBebidas
            // 
            labelBebidas.AutoSize = true;
            labelBebidas.ForeColor = SystemColors.Control;
            labelBebidas.Location = new Point(26, 476);
            labelBebidas.Name = "labelBebidas";
            labelBebidas.Size = new Size(48, 15);
            labelBebidas.TabIndex = 108;
            labelBebidas.Text = "Bebidas";
            // 
            // listBoxBebidaFinal
            // 
            listBoxBebidaFinal.FormattingEnabled = true;
            listBoxBebidaFinal.ItemHeight = 15;
            listBoxBebidaFinal.Location = new Point(26, 494);
            listBoxBebidaFinal.Name = "listBoxBebidaFinal";
            listBoxBebidaFinal.Size = new Size(1121, 124);
            listBoxBebidaFinal.TabIndex = 107;
            // 
            // labelPizzas
            // 
            labelPizzas.AutoSize = true;
            labelPizzas.ForeColor = SystemColors.Control;
            labelPizzas.Location = new Point(26, 195);
            labelPizzas.Name = "labelPizzas";
            labelPizzas.Size = new Size(44, 15);
            labelPizzas.TabIndex = 106;
            labelPizzas.Text = "Pizzas: ";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.ForeColor = SystemColors.Control;
            labelComplemento.Location = new Point(853, 106);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(87, 15);
            labelComplemento.TabIndex = 104;
            labelComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(946, 103);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.ReadOnly = true;
            txtComplemento.Size = new Size(219, 23);
            txtComplemento.TabIndex = 92;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(868, 144);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(81, 23);
            txtNumero.TabIndex = 91;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.ForeColor = SystemColors.Control;
            labelNumero.Location = new Point(805, 147);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(57, 15);
            labelNumero.TabIndex = 103;
            labelNumero.Text = "Número: ";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(744, 103);
            txtTelefone.Mask = "(99) 0 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(92, 23);
            txtTelefone.TabIndex = 82;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.ForeColor = SystemColors.Control;
            labelTelefone.Location = new Point(681, 106);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(57, 15);
            labelTelefone.TabIndex = 101;
            labelTelefone.Text = "Telefone: ";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(572, 103);
            txtCpf.Mask = "000.000.000 - 00";
            txtCpf.Name = "txtCpf";
            txtCpf.ReadOnly = true;
            txtCpf.Size = new Size(92, 23);
            txtCpf.TabIndex = 81;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.ForeColor = SystemColors.Control;
            labelCPF.Location = new Point(532, 103);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(34, 15);
            labelCPF.TabIndex = 100;
            labelCPF.Text = "CPF: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 100);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(428, 23);
            txtNome.TabIndex = 80;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.ForeColor = SystemColors.Control;
            labelNome.Location = new Point(26, 103);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(46, 15);
            labelNome.TabIndex = 99;
            labelNome.Text = "Nome: ";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.ForeColor = SystemColors.Control;
            labelBairro.Location = new Point(555, 147);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(41, 15);
            labelBairro.TabIndex = 98;
            labelBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(612, 144);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(173, 23);
            txtBairro.TabIndex = 88;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(107, 144);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.ReadOnly = true;
            txtLogradouro.Size = new Size(428, 23);
            txtLogradouro.TabIndex = 86;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.ForeColor = SystemColors.Control;
            labelLogradouro.Location = new Point(26, 147);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(75, 15);
            labelLogradouro.TabIndex = 94;
            labelLogradouro.Text = "Logradouro: ";
            // 
            // labelPagamento
            // 
            labelPagamento.Controls.Add(rbPix);
            labelPagamento.Controls.Add(rbCartao);
            labelPagamento.Controls.Add(rbDinheiro);
            labelPagamento.ForeColor = SystemColors.Control;
            labelPagamento.Location = new Point(509, 20);
            labelPagamento.Name = "labelPagamento";
            labelPagamento.Size = new Size(638, 55);
            labelPagamento.TabIndex = 1;
            labelPagamento.TabStop = false;
            labelPagamento.Text = "Forma de Pagamento:";
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(212, 22);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(41, 19);
            rbPix.TabIndex = 5;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(134, 22);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(60, 19);
            rbCartao.TabIndex = 4;
            rbCartao.Text = "Cartão";
            rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Checked = true;
            rbDinheiro.Location = new Point(33, 22);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(70, 19);
            rbDinheiro.TabIndex = 3;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // labelEntrega
            // 
            labelEntrega.Controls.Add(rbRetirada);
            labelEntrega.Controls.Add(rbEntrega);
            labelEntrega.ForeColor = SystemColors.Control;
            labelEntrega.Location = new Point(26, 20);
            labelEntrega.Name = "labelEntrega";
            labelEntrega.Size = new Size(269, 54);
            labelEntrega.TabIndex = 0;
            labelEntrega.TabStop = false;
            labelEntrega.Text = "Entrega:";
            // 
            // rbRetirada
            // 
            rbRetirada.AutoSize = true;
            rbRetirada.Checked = true;
            rbRetirada.Location = new Point(129, 22);
            rbRetirada.Name = "rbRetirada";
            rbRetirada.Size = new Size(68, 19);
            rbRetirada.TabIndex = 2;
            rbRetirada.TabStop = true;
            rbRetirada.Text = "Retirada";
            rbRetirada.UseVisualStyleBackColor = true;
            rbRetirada.CheckedChanged += rbRetirada_CheckedChanged;
            // 
            // rbEntrega
            // 
            rbEntrega.AutoSize = true;
            rbEntrega.Location = new Point(39, 22);
            rbEntrega.Name = "rbEntrega";
            rbEntrega.Size = new Size(65, 19);
            rbEntrega.TabIndex = 0;
            rbEntrega.Text = "Entrega";
            rbEntrega.UseVisualStyleBackColor = true;
            rbEntrega.CheckedChanged += rbRetirada_CheckedChanged;
            // 
            // btnRemover
            // 
            btnRemover.ForeColor = SystemColors.ControlText;
            btnRemover.Location = new Point(988, 595);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(150, 48);
            btnRemover.TabIndex = 14;
            btnRemover.Text = "Remover Pizza";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnRemoverBebida
            // 
            btnRemoverBebida.ForeColor = SystemColors.MenuText;
            btnRemoverBebida.Location = new Point(843, 325);
            btnRemoverBebida.Name = "btnRemoverBebida";
            btnRemoverBebida.Size = new Size(161, 43);
            btnRemoverBebida.TabIndex = 9;
            btnRemoverBebida.Text = "Remover Bebida";
            btnRemoverBebida.UseVisualStyleBackColor = true;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 802);
            Controls.Add(tabControl);
            ForeColor = SystemColors.ControlText;
            Name = "TelaPedidoForm";
            Text = "Cadastro de Pedidos";
            tabControl.ResumeLayout(false);
            tabCliente.ResumeLayout(false);
            tabCliente.PerformLayout();
            labelFiltro.ResumeLayout(false);
            labelFiltro.PerformLayout();
            tabPizza.ResumeLayout(false);
            tabPizza.PerformLayout();
            groupBoxPizza.ResumeLayout(false);
            groupBoxPizza.PerformLayout();
            tabBebida.ResumeLayout(false);
            boxBebidas.ResumeLayout(false);
            boxBebidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            tabFinalizar.ResumeLayout(false);
            tabFinalizar.PerformLayout();
            labelPagamento.ResumeLayout(false);
            labelPagamento.PerformLayout();
            labelEntrega.ResumeLayout(false);
            labelEntrega.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabCliente;
        private GroupBox labelFiltro;
        private RadioButton rbTelefone;
        private RadioButton rbCPF;
        private TabPage tabPizza;
        private Button btnIniciar;
        private Button btnPesquisar;
        private TextBox txtBusca;
        private RadioButton rbNome;
        private GroupBox groupBoxPizza;
        private Label labelTamanho;
        private ListBox listTamanho;
        private TextBox txtCliente;
        private Label labelBorda;
        private ListBox listBorda;
        private Label labelRemoverIngredientes;
        private ListBox listaSabores3;
        private ListBox listaSabores2;
        private ListBox listaSabores1;
        private Button btnAdicionarPizza;
        private Label txtValorPizza;
        private TabPage tabBebida;
        private GroupBox boxBebidas;
        private Button btnAddBebida;
        private Label labelCliente;
        private Label labelValorDaPizza;
        private ListBox listaClientes;
        private CheckedListBox listaIngredientes3;
        private CheckedListBox listaIngredientes2;
        private CheckedListBox listaIngredientes1;
        private ListBox listaPizzas;
        private ListBox listBoxBebidas;
        private ComboBox txtBebida;
        private NumericUpDown txtQuantidade;
        private Label labelListaBebidas;
        private Label labelQuantidade;
        private Label labelBebida;
        private TabPage tabFinalizar;
        private Button btnEncerrarPedido;
        private GroupBox labelPagamento;
        private RadioButton rbPix;
        private RadioButton rbCartao;
        private RadioButton rbDinheiro;
        private GroupBox labelEntrega;
        private RadioButton rbRetirada;
        private RadioButton rbEntrega;
        private Label labelComplemento;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private Label labelNumero;
        private MaskedTextBox txtTelefone;
        private Label labelTelefone;
        private MaskedTextBox txtCpf;
        private Label labelCPF;
        private TextBox txtNome;
        private Label labelNome;
        private Label labelBairro;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private Label labelLogradouro;
        private Label labelBebidas;
        private ListBox listBoxBebidaFinal;
        private Label labelPizzas;
        private Label labelValorFinal;
        private Label labelValorPedido;
        private ListBox lbPizza;
        private Button btnSalvar;
        private Button btnRemover;
        private Button btnRemoverBebida;
    }
}