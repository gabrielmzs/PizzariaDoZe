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
            labelCategoria = new GroupBox();
            rbEspecial = new RadioButton();
            rbTradicional = new RadioButton();
            labelTamanho = new GroupBox();
            rbFamilia = new RadioButton();
            rbGrande = new RadioButton();
            rbMedia = new RadioButton();
            rbPequena = new RadioButton();
            txtValor = new TextBox();
            labelValor = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtValorBorda = new TextBox();
            labelValorBorda = new Label();
            labelCategoria.SuspendLayout();
            labelTamanho.SuspendLayout();
            SuspendLayout();
            // 
            // labelCategoria
            // 
            labelCategoria.Controls.Add(rbEspecial);
            labelCategoria.Controls.Add(rbTradicional);
            labelCategoria.Location = new Point(294, 77);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(200, 77);
            labelCategoria.TabIndex = 7;
            labelCategoria.TabStop = false;
            labelCategoria.Text = "Categoria";
            // 
            // rbEspecial
            // 
            rbEspecial.AutoSize = true;
            rbEspecial.Location = new Point(17, 47);
            rbEspecial.Name = "rbEspecial";
            rbEspecial.Size = new Size(67, 19);
            rbEspecial.TabIndex = 9;
            rbEspecial.Text = "Especial";
            rbEspecial.UseVisualStyleBackColor = true;
            // 
            // rbTradicional
            // 
            rbTradicional.AutoSize = true;
            rbTradicional.Location = new Point(17, 22);
            rbTradicional.Name = "rbTradicional";
            rbTradicional.Size = new Size(82, 19);
            rbTradicional.TabIndex = 8;
            rbTradicional.Text = "Tradicional";
            rbTradicional.UseVisualStyleBackColor = true;
            // 
            // labelTamanho
            // 
            labelTamanho.Controls.Add(rbFamilia);
            labelTamanho.Controls.Add(rbGrande);
            labelTamanho.Controls.Add(rbMedia);
            labelTamanho.Controls.Add(rbPequena);
            labelTamanho.Location = new Point(42, 77);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(200, 151);
            labelTamanho.TabIndex = 2;
            labelTamanho.TabStop = false;
            labelTamanho.Text = "Tamanho";
            // 
            // rbFamilia
            // 
            rbFamilia.AutoSize = true;
            rbFamilia.Location = new Point(17, 97);
            rbFamilia.Name = "rbFamilia";
            rbFamilia.Size = new Size(63, 19);
            rbFamilia.TabIndex = 6;
            rbFamilia.Text = "Família";
            rbFamilia.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            rbGrande.AutoSize = true;
            rbGrande.Location = new Point(17, 72);
            rbGrande.Name = "rbGrande";
            rbGrande.Size = new Size(63, 19);
            rbGrande.TabIndex = 5;
            rbGrande.Text = "Grande";
            rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            rbMedia.AutoSize = true;
            rbMedia.Location = new Point(17, 47);
            rbMedia.Name = "rbMedia";
            rbMedia.Size = new Size(58, 19);
            rbMedia.TabIndex = 4;
            rbMedia.Text = "Média";
            rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbPequena
            // 
            rbPequena.AutoSize = true;
            rbPequena.Location = new Point(17, 22);
            rbPequena.Name = "rbPequena";
            rbPequena.Size = new Size(71, 19);
            rbPequena.TabIndex = 3;
            rbPequena.Text = "Pequena";
            rbPequena.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(54, 25);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(149, 23);
            txtValor.TabIndex = 0;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(12, 28);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(36, 15);
            labelValor.TabIndex = 93;
            labelValor.Text = "Valor:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(460, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 60);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(360, 189);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 60);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtValorBorda
            // 
            txtValorBorda.Location = new Point(402, 25);
            txtValorBorda.Name = "txtValorBorda";
            txtValorBorda.Size = new Size(130, 23);
            txtValorBorda.TabIndex = 1;
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(254, 28);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(123, 15);
            labelValorBorda.TabIndex = 97;
            labelValorBorda.Text = "Valor Adicional Borda:";
            // 
            // TelaValorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 261);
            Controls.Add(txtValorBorda);
            Controls.Add(labelValorBorda);
            Controls.Add(labelCategoria);
            Controls.Add(labelTamanho);
            Controls.Add(txtValor);
            Controls.Add(labelValor);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "TelaValorForm";
            Text = "Cadastrar Valor da Pizza";
            labelCategoria.ResumeLayout(false);
            labelCategoria.PerformLayout();
            labelTamanho.ResumeLayout(false);
            labelTamanho.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtValor;
        private Label labelValor;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtValorBorda;
        private Label labelValorBorda;
    }
}