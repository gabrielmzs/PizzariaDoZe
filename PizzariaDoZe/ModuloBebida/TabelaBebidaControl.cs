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

namespace PizzariaDoZe.ModuloBebida {
    public partial class TabelaBebidaControl : UserControl {
        public TabelaBebidaControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Tamanho", HeaderText = "Tamanho", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Valor", HeaderText = "Valor", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Tipo", HeaderText = "Tipo", FillWeight=30F },


            };
            return colunas;
        }
    }
}
