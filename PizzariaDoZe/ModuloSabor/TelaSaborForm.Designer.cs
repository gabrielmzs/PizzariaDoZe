namespace PizzariaDoZe.ModuloSabor {
    partial class TelaSaborForm {
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.GroupBox();
            this.rbSalgada = new System.Windows.Forms.RadioButton();
            this.rbDoce = new System.Windows.Forms.RadioButton();
            this.fotoSabor = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBoxIngredientes = new System.Windows.Forms.CheckedListBox();
            this.labelIngredientes = new System.Windows.Forms.Label();
            this.labelCategoria.SuspendLayout();
            this.labelTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSabor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCategoria
            // 
            this.labelCategoria.Controls.Add(this.rbEspecial);
            this.labelCategoria.Controls.Add(this.rbTradicional);
            this.labelCategoria.Location = new System.Drawing.Point(35, 103);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelCategoria.Size = new System.Drawing.Size(229, 103);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.TabStop = false;
            this.labelCategoria.Text = "Categoria";
            // 
            // rbEspecial
            // 
            this.rbEspecial.AutoSize = true;
            this.rbEspecial.Location = new System.Drawing.Point(19, 63);
            this.rbEspecial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbEspecial.Name = "rbEspecial";
            this.rbEspecial.Size = new System.Drawing.Size(84, 24);
            this.rbEspecial.TabIndex = 4;
            this.rbEspecial.Text = "Especial";
            this.rbEspecial.UseVisualStyleBackColor = true;
            // 
            // rbTradicional
            // 
            this.rbTradicional.AutoSize = true;
            this.rbTradicional.Checked = true;
            this.rbTradicional.Location = new System.Drawing.Point(19, 29);
            this.rbTradicional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTradicional.Name = "rbTradicional";
            this.rbTradicional.Size = new System.Drawing.Size(103, 24);
            this.rbTradicional.TabIndex = 3;
            this.rbTradicional.TabStop = true;
            this.rbTradicional.Text = "Tradicional";
            this.rbTradicional.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(98, 32);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(501, 27);
            this.textBox6.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(39, 36);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(57, 20);
            this.labelNome.TabIndex = 65;
            this.labelNome.Text = "Nome: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(930, 684);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 80);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(816, 684);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 80);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // labelTipo
            // 
            this.labelTipo.Controls.Add(this.rbSalgada);
            this.labelTipo.Controls.Add(this.rbDoce);
            this.labelTipo.Location = new System.Drawing.Point(315, 103);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelTipo.Size = new System.Drawing.Size(229, 103);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.TabStop = false;
            this.labelTipo.Text = "Tipo";
            // 
            // rbSalgada
            // 
            this.rbSalgada.AutoSize = true;
            this.rbSalgada.Checked = true;
            this.rbSalgada.Location = new System.Drawing.Point(19, 63);
            this.rbSalgada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSalgada.Name = "rbSalgada";
            this.rbSalgada.Size = new System.Drawing.Size(84, 24);
            this.rbSalgada.TabIndex = 7;
            this.rbSalgada.TabStop = true;
            this.rbSalgada.Text = "Salgada";
            this.rbSalgada.UseVisualStyleBackColor = true;
            // 
            // rbDoce
            // 
            this.rbDoce.AutoSize = true;
            this.rbDoce.Location = new System.Drawing.Point(19, 29);
            this.rbDoce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDoce.Name = "rbDoce";
            this.rbDoce.Size = new System.Drawing.Size(65, 24);
            this.rbDoce.TabIndex = 6;
            this.rbDoce.Text = "Doce";
            this.rbDoce.UseVisualStyleBackColor = true;
            // 
            // fotoSabor
            // 
            this.fotoSabor.Image = global::PizzariaDoZe.Properties.Resources.Yellow_Neon_Pizza_Restaurant_Logo;
            this.fotoSabor.InitialImage = global::PizzariaDoZe.Properties.Resources.Yellow_Neon_Pizza_Restaurant_Logo;
            this.fotoSabor.Location = new System.Drawing.Point(35, 231);
            this.fotoSabor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fotoSabor.Name = "fotoSabor";
            this.fotoSabor.Size = new System.Drawing.Size(423, 399);
            this.fotoSabor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoSabor.TabIndex = 87;
            this.fotoSabor.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(481, 387);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 76);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxIngredientes
            // 
            this.listBoxIngredientes.FormattingEnabled = true;
            this.listBoxIngredientes.Location = new System.Drawing.Point(598, 103);
            this.listBoxIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxIngredientes.Name = "listBoxIngredientes";
            this.listBoxIngredientes.Size = new System.Drawing.Size(373, 488);
            this.listBoxIngredientes.TabIndex = 89;
            this.listBoxIngredientes.TabStop = false;
            // 
            // labelIngredientes
            // 
            this.labelIngredientes.AutoSize = true;
            this.labelIngredientes.Location = new System.Drawing.Point(598, 79);
            this.labelIngredientes.Name = "labelIngredientes";
            this.labelIngredientes.Size = new System.Drawing.Size(98, 20);
            this.labelIngredientes.TabIndex = 90;
            this.labelIngredientes.Text = "Ingredientes: ";
            // 
            // TelaSaborForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 780);
            this.Controls.Add(this.labelIngredientes);
            this.Controls.Add(this.listBoxIngredientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.fotoSabor);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaSaborForm";
            this.Text = "Cadastro de Sabor";
            this.labelCategoria.ResumeLayout(false);
            this.labelCategoria.PerformLayout();
            this.labelTipo.ResumeLayout(false);
            this.labelTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSabor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox labelCategoria;
        private RadioButton rbEspecial;
        private RadioButton rbTradicional;
        private TextBox textBox6;
        private Label labelNome;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox labelTipo;
        private RadioButton rbSalgada;
        private RadioButton rbDoce;
        private PictureBox fotoSabor;
        private Button btnBuscar;
        private CheckedListBox listBoxIngredientes;
        private Label labelIngredientes;
    }
}