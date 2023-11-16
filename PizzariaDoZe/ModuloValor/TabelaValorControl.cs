using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloValor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloValor {
    public partial class TabelaValorControl : UserControl {
        public TabelaValorControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Tamanho", HeaderText = "Tamanho", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Valor Borda", HeaderText = "Valor Borda", FillWeight=30F },


            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Valor> valores) {
            grid.Rows.Clear();

            foreach (Valor v in valores) {

                grid.Rows.Add(v.Id, v.Tamanho, v.Categoria, "R$: " + v.ValorPizza, "R$: " + v.ValorBorda);
            }
        }
    }
}
