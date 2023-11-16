using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
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

        public void AtualizarRegistros(List<Bebida> bebidas) {
            grid.Rows.Clear();

            foreach (Bebida b in bebidas) {

                string tamanho = VerificarTamanho(b.Tamanho);
                grid.Rows.Add(b.Id, b.Nome, tamanho , "R$: "+b.Valor, b.Tipo);
            }
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        private string VerificarTamanho(TamanhoBebidaEnum tamanho) {
            if (tamanho == TamanhoBebidaEnum.ml150) return "150 ml";
            else if (tamanho == TamanhoBebidaEnum.ml350) return "350 ml";
            else if (tamanho == TamanhoBebidaEnum.ml500) return "500 ml";
            else if (tamanho == TamanhoBebidaEnum.ml600) return "600 ml";
            else if (tamanho == TamanhoBebidaEnum.litro1) return "1 l";
            else if (tamanho == TamanhoBebidaEnum.litro15) return "1.5 l";
            else return "2 l";
        }
    }

    
}
