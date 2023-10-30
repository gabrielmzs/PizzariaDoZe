using PizzariaDoZe.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloSabor {
    public partial class TelaSaborForm : Form {
        public TelaSaborForm() {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);
        }

        private void button3_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Selecione uma imagem";

            // Exibe o OpenFileDialog e verifica se o usuário clicou em "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                // Obtém o caminho do arquivo selecionado pelo usuário
                string caminhoDaImagem = openFileDialog.FileName;

                // Carrega a imagem do arquivo selecionado
                Image imagem = Image.FromFile(caminhoDaImagem);

                // Exibe a imagem no PictureBox
                fotoSabor.Image = imagem;
            }
        }
    }
}
