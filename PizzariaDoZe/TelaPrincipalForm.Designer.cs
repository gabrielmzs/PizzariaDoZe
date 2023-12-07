namespace PizzariaDoZe {
    partial class TelaPrincipalForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            panel1 = new Panel();
            labelGrupo = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            btnPedido = new Button();
            btnIngrediente = new Button();
            btnBebida = new Button();
            btnValor = new Button();
            btnSabor = new Button();
            btnCliente = new Button();
            btnFuncionario = new Button();
            btnEndereco = new Button();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            inícioToolStripMenuItem = new ToolStripMenuItem();
            logradouroShiftF2ToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            bebidasToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            labelTipoCadastro = new Label();
            btnInserir = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnConfigurar = new Button();
            panel2 = new Panel();
            panelRegistros = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStripPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labelGrupo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPedido);
            panel1.Controls.Add(btnIngrediente);
            panel1.Controls.Add(btnBebida);
            panel1.Controls.Add(btnValor);
            panel1.Controls.Add(btnSabor);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(btnFuncionario);
            panel1.Controls.Add(btnEndereco);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 735);
            panel1.TabIndex = 0;
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrupo.ForeColor = Color.White;
            labelGrupo.Location = new Point(152, 76);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(53, 20);
            labelGrupo.TabIndex = 8;
            labelGrupo.Text = "Grupo";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(152, 37);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(63, 20);
            labelUsuario.TabIndex = 7;
            labelUsuario.Text = "Usuário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2023_08_15_224831;
            pictureBox1.Location = new Point(11, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnPedido
            // 
            btnPedido.Anchor = AnchorStyles.Left;
            btnPedido.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnPedido.Image = Properties.Resources.list_alt_FILL0_wght400_GRAD0_opsz48;
            btnPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedido.Location = new Point(11, 660);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(233, 69);
            btnPedido.TabIndex = 7;
            btnPedido.Text = "         Pedidos";
            btnPedido.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnIngrediente
            // 
            btnIngrediente.Anchor = AnchorStyles.Left;
            btnIngrediente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngrediente.Image = Properties.Resources.extension_FILL0_wght400_GRAD0_opsz48;
            btnIngrediente.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngrediente.Location = new Point(11, 510);
            btnIngrediente.Name = "btnIngrediente";
            btnIngrediente.Size = new Size(233, 69);
            btnIngrediente.TabIndex = 5;
            btnIngrediente.Text = "         Ingredientes";
            btnIngrediente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngrediente.UseVisualStyleBackColor = true;
            btnIngrediente.Click += btnIngrediente_Click;
            // 
            // btnBebida
            // 
            btnBebida.Anchor = AnchorStyles.Left;
            btnBebida.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBebida.Image = Properties.Resources.liquor_FILL0_wght400_GRAD0_opsz48;
            btnBebida.ImageAlign = ContentAlignment.MiddleLeft;
            btnBebida.Location = new Point(11, 585);
            btnBebida.Name = "btnBebida";
            btnBebida.Size = new Size(233, 69);
            btnBebida.TabIndex = 6;
            btnBebida.Text = "         Bebidas";
            btnBebida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBebida.UseVisualStyleBackColor = true;
            btnBebida.Click += btnBebida_Click;
            // 
            // btnValor
            // 
            btnValor.Anchor = AnchorStyles.Left;
            btnValor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor.Image = Properties.Resources.request_page_FILL0_wght400_GRAD0_opsz48;
            btnValor.ImageAlign = ContentAlignment.MiddleLeft;
            btnValor.Location = new Point(11, 435);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(233, 69);
            btnValor.TabIndex = 4;
            btnValor.Text = "         Valores";
            btnValor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnSabor
            // 
            btnSabor.Anchor = AnchorStyles.Left;
            btnSabor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSabor.Image = Properties.Resources.local_pizza_FILL0_wght400_GRAD0_opsz48;
            btnSabor.ImageAlign = ContentAlignment.MiddleLeft;
            btnSabor.Location = new Point(11, 360);
            btnSabor.Name = "btnSabor";
            btnSabor.Size = new Size(233, 69);
            btnSabor.TabIndex = 3;
            btnSabor.Text = "         Sabores";
            btnSabor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSabor.UseVisualStyleBackColor = true;
            btnSabor.Click += btnSabor_Click;
            // 
            // btnCliente
            // 
            btnCliente.Anchor = AnchorStyles.Left;
            btnCliente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCliente.Image = Properties.Resources.group_FILL0_wght400_GRAD0_opsz48;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(11, 285);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(233, 69);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "         Clientes";
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Anchor = AnchorStyles.Left;
            btnFuncionario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnFuncionario.Image = Properties.Resources.badge_FILL0_wght400_GRAD0_opsz48;
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.Location = new Point(11, 210);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(233, 69);
            btnFuncionario.TabIndex = 1;
            btnFuncionario.Text = "         Funcionários";
            btnFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnEndereco
            // 
            btnEndereco.Anchor = AnchorStyles.Left;
            btnEndereco.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEndereco.Image = Properties.Resources.home_FILL0_wght400_GRAD0_opsz48;
            btnEndereco.ImageAlign = ContentAlignment.MiddleLeft;
            btnEndereco.Location = new Point(11, 138);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(233, 69);
            btnEndereco.TabIndex = 0;
            btnEndereco.Text = "         Endereços";
            btnEndereco.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEndereco.UseVisualStyleBackColor = true;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSystemTray.BalloonTipText = "Aplicação Continua Executando";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripPrincipal;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do  Zé";
            notifyIconSystemTray.Visible = true;
            notifyIconSystemTray.DoubleClick += notifyIconSystemTray_DoubleClick;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, logradouroShiftF2ToolStripMenuItem, funcionáriosToolStripMenuItem, clientesToolStripMenuItem, saboresToolStripMenuItem, valoresToolStripMenuItem, ingredientesToolStripMenuItem, bebidasToolStripMenuItem, configuraçõesToolStripMenuItem, sobreToolStripMenuItem, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(209, 246);
            contextMenuStripPrincipal.Opening += contextMenuStripPrincipal_Opening;
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            inícioToolStripMenuItem.Size = new Size(208, 22);
            inícioToolStripMenuItem.Text = "Início";
            // 
            // logradouroShiftF2ToolStripMenuItem
            // 
            logradouroShiftF2ToolStripMenuItem.Name = "logradouroShiftF2ToolStripMenuItem";
            logradouroShiftF2ToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            logradouroShiftF2ToolStripMenuItem.Size = new Size(208, 22);
            logradouroShiftF2ToolStripMenuItem.Text = "Logradouro ";
            logradouroShiftF2ToolStripMenuItem.Click += btnEndereco_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            funcionáriosToolStripMenuItem.Size = new Size(208, 22);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += btnFuncionario_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            clientesToolStripMenuItem.Size = new Size(208, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += btnCliente_Click;
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            saboresToolStripMenuItem.Size = new Size(208, 22);
            saboresToolStripMenuItem.Text = "Sabores";
            saboresToolStripMenuItem.Click += btnSabor_Click;
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            valoresToolStripMenuItem.Size = new Size(208, 22);
            valoresToolStripMenuItem.Text = "Valores";
            valoresToolStripMenuItem.Click += btnValor_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            ingredientesToolStripMenuItem.Size = new Size(208, 22);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += btnIngrediente_Click;
            // 
            // bebidasToolStripMenuItem
            // 
            bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            bebidasToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F8;
            bebidasToolStripMenuItem.Size = new Size(208, 22);
            bebidasToolStripMenuItem.Text = "Bebidas";
            bebidasToolStripMenuItem.Click += btnBebida_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F10;
            configuraçõesToolStripMenuItem.Size = new Size(208, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += btnConfigurar_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(208, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            sairToolStripMenuItem.Size = new Size(208, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.AutoSize = true;
            labelTipoCadastro.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoCadastro.ForeColor = Color.White;
            labelTipoCadastro.Location = new Point(28, 12);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(219, 54);
            labelTipoCadastro.TabIndex = 8;
            labelTipoCadastro.Text = "Tela Inicial";
            // 
            // btnInserir
            // 
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz48;
            btnInserir.Location = new Point(38, 87);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(62, 49);
            btnInserir.TabIndex = 9;
            btnInserir.TabStop = false;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            btnEditar.Location = new Point(106, 87);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 49);
            btnEditar.TabIndex = 10;
            btnEditar.TabStop = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            btnExcluir.Location = new Point(174, 87);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(62, 49);
            btnExcluir.TabIndex = 11;
            btnExcluir.TabStop = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnConfigurar
            // 
            btnConfigurar.Location = new Point(848, 107);
            btnConfigurar.Margin = new Padding(3, 2, 3, 2);
            btnConfigurar.Name = "btnConfigurar";
            btnConfigurar.Size = new Size(109, 22);
            btnConfigurar.TabIndex = 12;
            btnConfigurar.TabStop = false;
            btnConfigurar.Text = "Configurações";
            btnConfigurar.UseVisualStyleBackColor = true;
            btnConfigurar.Click += btnConfigurar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnConfigurar);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnInserir);
            panel2.Controls.Add(labelTipoCadastro);
            panel2.Location = new Point(259, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 178);
            panel2.TabIndex = 1;
            // 
            // panelRegistros
            // 
            panelRegistros.Location = new Point(259, 177);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(972, 558);
            panelRegistros.TabIndex = 2;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 734);
            ContextMenuStrip = contextMenuStripPrincipal;
            Controls.Add(panelRegistros);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1244, 796);
            MinimumSize = new Size(1244, 773);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé";
            FormClosing += TelaPrincipalForm_FormClosing;
            Resize += TelaPrincipalForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStripPrincipal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEndereco;
        private PictureBox pictureBox1;
        private Button btnPedido;
        private Button btnIngrediente;
        private Button btnBebida;
        private Button btnValor;
        private Button btnSabor;
        private Button btnCliente;
        private Button btnFuncionario;
        private Label labelGrupo;
        private Label labelUsuario;
        private NotifyIcon notifyIconSystemTray;
        private Label labelTipoCadastro;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnConfigurar;
        private Panel panel2;
        private Panel panelRegistros;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private ToolStripMenuItem logradouroShiftF2ToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem bebidasToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}