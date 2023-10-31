using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Dominio.ModuloSabor;
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

        private Sabor sabor;
        public event GravarRegistroDelegate<Sabor> onGravarRegistro;
        private IRepositorioIngrediente RepositorioIngrediente;

        public TelaSaborForm(IRepositorioIngrediente repositorioIngrediente) {
            this.RepositorioIngrediente = repositorioIngrediente;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);
            CarregarIngredientes();
        }

        private void CarregarIngredientes() {
            List<Ingrediente> listaIngredientes = RepositorioIngrediente.SelecionarTodos();

            foreach (var i in listaIngredientes) {
                listBoxIngredientes.Items.Add(i);
            }
        }

        public void ConfigurarSabor(Sabor sabor) {

            this.sabor = sabor;
            txtNome.Text = sabor.Nome;
            ConfigurarCategoria(sabor.Categoria);
            ConfigurarTipo(sabor.Tipo);
            if(sabor.Ingredientes!= null) {
            ConfigurarIngredientes(sabor.Ingredientes);

            }
            
            



        }

        private void ConfigurarTipo(TipoSaborEnum tipo) {
            if (tipo == TipoSaborEnum.Doce) rbDoce.Checked = true;
            else rbSalgada.Checked = true;
        }

        private void ConfigurarIngredientes(List<Ingrediente> lista) {
            foreach (var i in lista) {
                listBoxIngredientes.SetItemChecked(listBoxIngredientes.Items.IndexOf(i), true);
            }
        }

        private void ConfigurarCategoria(CategoriaSaborEnum categoria) {
            if (categoria == CategoriaSaborEnum.Tradicional) rbTradicional.Checked = true;
            else rbEspecial.Checked = true;
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
