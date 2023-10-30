namespace PizzariaDoZe.ModuloFuncionario {
    partial class TelaLoginForm {
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
            this.btnAcessar = new System.Windows.Forms.Button();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcessar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAcessar.Location = new System.Drawing.Point(178, 109);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(94, 60);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(31, 29);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(63, 15);
            this.labelMatricula.TabIndex = 18;
            this.labelMatricula.Text = "Matrícula: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(31, 64);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(45, 15);
            this.labelSenha.TabIndex = 20;
            this.labelSenha.Text = "Senha: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // TelaLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 181);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.btnAcessar);
            this.Name = "TelaLoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAcessar;
        private Label labelMatricula;
        private TextBox textBox1;
        private Label labelSenha;
        private TextBox textBox2;
    }
}