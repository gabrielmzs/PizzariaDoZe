using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloIngrediente {
    public partial class TabelaIngredienteControl : UserControl {
        public TabelaIngredienteControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=60F },

        
            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Ingrediente> ingredientes) {
            grid.Rows.Clear();

            foreach (Ingrediente i in ingredientes) {
                grid.Rows.Add(i.Id, i.Nome);
            }
        }
    }
}
