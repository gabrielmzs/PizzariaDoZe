namespace PizzariaDoZe.ModuloEndereco {
    partial class TelaEnderecoForm {
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(374, 185);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 60);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(474, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 60);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(31, 29);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(34, 15);
            this.labelCep.TabIndex = 2;
            this.labelCep.Text = "CEP: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(428, 23);
            this.textBox2.TabIndex = 2;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(31, 58);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(75, 15);
            this.labelLogradouro.TabIndex = 4;
            this.labelLogradouro.Text = "Logradouro: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 26);
            this.maskedTextBox1.Mask = "00000-999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(66, 23);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 3;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(31, 119);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(34, 15);
            this.labelPais.TabIndex = 7;
            this.labelPais.Text = "País: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(383, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 23);
            this.textBox3.TabIndex = 4;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(289, 119);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(27, 15);
            this.labelUF.TabIndex = 9;
            this.labelUF.Text = "UF: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 23);
            this.textBox4.TabIndex = 5;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(31, 92);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(50, 15);
            this.labelCidade.TabIndex = 11;
            this.labelCidade.Text = "Cidade: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(383, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(157, 23);
            this.textBox5.TabIndex = 6;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(289, 87);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(41, 15);
            this.labelBairro.TabIndex = 13;
            this.labelBairro.Text = "Bairro:";
            // 
            // TelaEnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 257);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "TelaEnderecoForm";
            this.Text = "Cadastro de Endereço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private Label labelCep;
        private TextBox textBox2;
        private Label labelLogradouro;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label labelPais;
        private TextBox textBox3;
        private Label labelUF;
        private TextBox textBox4;
        private Label labelCidade;
        private TextBox textBox5;
        private Label labelBairro;
    }
}