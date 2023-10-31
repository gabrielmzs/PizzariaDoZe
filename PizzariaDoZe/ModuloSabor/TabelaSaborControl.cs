using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloFuncionario;
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
    public partial class TabelaSaborControl : UserControl {

        public TabelaSaborControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());

            // Ajusta a altura das linhas para exibir corretamente as imagens
            AjustarAlturaLinhas(grid, 60); // Altere 60 para a altura desejada das linhas
        }

        public DataGridViewColumn[] ObterColunas() {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight = 15F, Visible = false },
                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight = 20F },
                new DataGridViewImageColumn { Name = "Foto", HeaderText = "Foto", FillWeight = 15F, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { NullValue = null } },
                new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", FillWeight = 15F },
                new DataGridViewTextBoxColumn { Name = "Tipo", HeaderText = "Tipo", FillWeight = 15F },
                new DataGridViewTextBoxColumn { Name = "Ingredientes", HeaderText = "Ingredientes", FillWeight = 80F },
            };
            return colunas;
        }

        public void AtualizarRegistros(List<Sabor> sabores) {
            grid.Rows.Clear();

            int imageWidth = 100; // Largura desejada da imagem
            int imageHeight = 40; // Altura das linhas (ajustada para a altura desejada)

            foreach (Sabor s in sabores) {
                Image originalImage = ByteArrayToImage(s.Foto);
                Image resizedImage = ResizeImage(originalImage, imageWidth, imageHeight);

                string ingredientes = string.Join(", ", s.Ingredientes.Select(i => i.Nome));

                grid.Rows.Add(s.Id, s.Nome, resizedImage, s.Categoria, s.Tipo, ingredientes);
            }
        }

        static Image ByteArrayToImage(byte[] byteArray) {
            using (MemoryStream ms = new MemoryStream(byteArray)) {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }

        static Image ResizeImage(Image image, int width, int height) {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result)) {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }

        public void AjustarAlturaLinhas(DataGridView grid, int novaAltura) {
            grid.RowTemplate.Height = novaAltura;
        }
    }
}

