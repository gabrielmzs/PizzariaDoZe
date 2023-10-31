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
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=60F },
                new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Tipo", HeaderText = "Tipo", FillWeight=30F },


            };
            return colunas;
        }


        public void AtualizarRegistros(List<Sabor> sabores) {
            grid.Rows.Clear();

            foreach (Sabor s in sabores) {


                grid.Rows.Add(s.Id, s.Nome, s.Categoria, s.Tipo);
            }
        }
    }
}
