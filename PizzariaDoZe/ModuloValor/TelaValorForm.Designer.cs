namespace PizzariaDoZe.ModuloValor {
    partial class TelaValorForm {
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
            this.labelCategoria = new System.Windows.Forms.GroupBox();
            this.rbEspecial = new System.Windows.Forms.RadioButton();
            this.rbTradicional = new System.Windows.Forms.RadioButton();
            this.labelTamanho = new System.Windows.Forms.GroupBox();
            this.rbFamilia = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbPequena = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelValorBorda = new System.Windows.Forms.Label();
            this.labelCategoria.SuspendLayout();
            this.labelTamanho.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCategoria
            // 
            this.labelCategoria.Controls.Add(this.rbEspecial);
            this.labelCategoria.Controls.Add(this.rbTradicional);
            this.labelCategoria.Location = new System.Drawing.Point(294, 77);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(200, 77);
            this.labelCategoria.TabIndex = 7;
            this.labelCategoria.TabStop = false;
            this.labelCategoria.Text = "Categoria";
            // 
            // rbEspecial
            // 
            this.rbEspecial.AutoSize = true;
            this.rbEspecial.Location = new System.Drawing.Point(17, 47);
            this.rbEspecial.Name = "rbEspecial";
            this.rbEspecial.Size = new System.Drawing.Size(67, 19);
            this.rbEspecial.TabIndex = 9;
            this.rbEspecial.Text = "Especial";
            this.rbEspecial.UseVisualStyleBackColor = true;
            // 
            // rbTradicional
            // 
            this.rbTradicional.AutoSize = true;
            this.rbTradicional.Location = new System.Drawing.Point(17, 22);
            this.rbTradicional.Name = "rbTradicional";
            this.rbTradicional.Size = new System.Drawing.Size(82, 19);
            this.rbTradicional.TabIndex = 8;
            this.rbTradicional.Text = "Tradicional";
            this.rbTradicional.UseVisualStyleBackColor = true;
            // 
            // labelTamanho
            // 
            this.labelTamanho.Controls.Add(this.rbFamilia);
            this.labelTamanho.Controls.Add(this.rbGrande);
            this.labelTamanho.Controls.Add(this.rbMedia);
            this.labelTamanho.Controls.Add(this.rbPequena);
            this.labelTamanho.Location = new System.Drawing.Point(42, 77);
            this.labelTamanho.Name = "labelTamanho";
            this.labelTamanho.Size = new System.Drawing.Size(200, 151);
            this.labelTamanho.TabIndex = 2;
            this.labelTamanho.TabStop = false;
            this.labelTamanho.Text = "Tamanho";
            // 
            // rbFamilia
            // 
            this.rbFamilia.AutoSize = true;
            this.rbFamilia.Location = new System.Drawing.Point(17, 97);
            this.rbFamilia.Name = "rbFamilia";
            this.rbFamilia.Size = new System.Drawing.Size(63, 19);
            this.rbFamilia.TabIndex = 6;
            this.rbFamilia.Text = "Família";
            this.rbFamilia.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(17, 72);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(63, 19);
            this.rbGrande.TabIndex = 5;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(17, 47);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(58, 19);
            this.rbMedia.TabIndex = 4;
            this.rbMedia.Text = "Média";
            this.rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbPequena
            // 
            this.rbPequena.AutoSize = true;
            this.rbPequena.Location = new System.Drawing.Point(17, 22);
            this.rbPequena.Name = "rbPequena";
            this.rbPequena.Size = new System.Drawing.Size(71, 19);
            this.rbPequena.TabIndex = 3;
            this.rbPequena.Text = "Pequena";
            this.rbPequena.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(54, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 23);
            this.textBox6.TabIndex = 0;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(12, 28);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 15);
            this.labelValor.TabIndex = 93;
            this.labelValor.Text = "Valor:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(460, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 60);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(360, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 60);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelValorBorda
            // 
            this.labelValorBorda.AutoSize = true;
            this.labelValorBorda.Location = new System.Drawing.Point(254, 28);
            this.labelValorBorda.Name = "labelValorBorda";
            this.labelValorBorda.Size = new System.Drawing.Size(123, 15);
            this.labelValorBorda.TabIndex = 97;
            this.labelValorBorda.Text = "Valor Adicional Borda:";
            // 
            // TelaValorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelValorBorda);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelTamanho);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "TelaValorForm";
            this.Text = "Cadastrar Valor da Pizza";
            this.labelCategoria.ResumeLayout(false);
            this.labelCategoria.PerformLayout();
            this.labelTamanho.ResumeLayout(false);
            this.labelTamanho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox labelCategoria;
        private RadioButton rbEspecial;
        private RadioButton rbTradicional;
        private GroupBox labelTamanho;
        private RadioButton rbFamilia;
        private RadioButton rbGrande;
        private RadioButton rbMedia;
        private RadioButton rbPequena;
        private TextBox textBox6;
        private Label labelValor;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox textBox1;
        private Label labelValorBorda;
    }
}