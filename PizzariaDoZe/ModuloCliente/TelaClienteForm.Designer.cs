namespace PizzariaDoZe.ModuloCliente {
    partial class TelaClienteForm {
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(428, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(43, 107);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 15);
            this.labelEmail.TabIndex = 74;
            this.labelEmail.Text = "Email: ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(314, 57);
            this.txtTelefone.Mask = "(99) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(92, 23);
            this.txtTelefone.TabIndex = 3;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(251, 62);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(57, 15);
            this.labelTelefone.TabIndex = 72;
            this.labelTelefone.Text = "Telefone: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(196, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 27);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(124, 62);
            this.txtCpf.Mask = "000.000.000 - 00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(92, 23);
            this.txtCpf.TabIndex = 2;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(43, 65);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(34, 15);
            this.labelCPF.TabIndex = 67;
            this.labelCPF.Text = "CPF: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(428, 23);
            this.txtNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(43, 26);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 15);
            this.labelNome.TabIndex = 65;
            this.labelNome.Text = "Nome: ";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(379, 249);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(173, 23);
            this.txtEstado.TabIndex = 11;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(293, 220);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(41, 15);
            this.labelBairro.TabIndex = 63;
            this.labelBairro.Text = "Bairro:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(124, 246);
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.Size = new System.Drawing.Size(163, 23);
            this.txtPais.TabIndex = 10;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(43, 220);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(50, 15);
            this.labelCidade.TabIndex = 61;
            this.labelCidade.Text = "Cidade: ";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(379, 217);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(173, 23);
            this.txtBairro.TabIndex = 9;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(293, 249);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(27, 15);
            this.labelUF.TabIndex = 59;
            this.labelUF.Text = "UF: ";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(124, 217);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(163, 23);
            this.txtCidade.TabIndex = 8;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(43, 252);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(34, 15);
            this.labelPais.TabIndex = 57;
            this.labelPais.Text = "País: ";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(124, 159);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(66, 23);
            this.txtCep.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(124, 188);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.ReadOnly = true;
            this.txtLogradouro.Size = new System.Drawing.Size(428, 23);
            this.txtLogradouro.TabIndex = 7;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(43, 191);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(75, 15);
            this.labelLogradouro.TabIndex = 54;
            this.labelLogradouro.Text = "Logradouro: ";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(43, 162);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(34, 15);
            this.labelCep.TabIndex = 53;
            this.labelCep.Text = "CEP: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(476, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 60);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(376, 344);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 60);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(43, 290);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(57, 15);
            this.labelNumero.TabIndex = 76;
            this.labelNumero.Text = "Número: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(124, 287);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(81, 23);
            this.txtNumero.TabIndex = 12;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(313, 287);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(239, 23);
            this.txtComplemento.TabIndex = 13;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(221, 293);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(87, 15);
            this.labelComplemento.TabIndex = 79;
            this.labelComplemento.Text = "Complemento:";
            // 
            // TelaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 416);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "TelaClienteForm";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private Label labelEmail;
        private MaskedTextBox txtTelefone;
        private Label labelTelefone;
        private Button btnBuscar;
        private MaskedTextBox txtCpf;
        private Label labelCPF;
        private TextBox txtNome;
        private Label labelNome;
        private TextBox txtEstado;
        private Label labelBairro;
        private TextBox txtPais;
        private Label labelCidade;
        private TextBox txtBairro;
        private Label labelUF;
        private TextBox txtCidade;
        private Label labelPais;
        private MaskedTextBox txtCep;
        private TextBox txtLogradouro;
        private Label labelLogradouro;
        private Label labelCep;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label labelNumero;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private Label labelComplemento;
    }
}