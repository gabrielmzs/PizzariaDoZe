using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloEndereco {
    public partial class TabelaEnderecoControl : UserControl {
        public TabelaEnderecoControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "CEP", HeaderText = "CEP", FillWeight=20F },
                
                new DataGridViewTextBoxColumn { Name = "Logradouro", HeaderText = "Logradouro", FillWeight=60F },

                new DataGridViewTextBoxColumn { Name = "Bairro", HeaderText = "Bairro", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Cidade", HeaderText = "Cidade", FillWeight=30F },


            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Endereco> enderecos) {
            grid.Rows.Clear();

            foreach (Endereco e in enderecos) {
                grid.Rows.Add(e.Id, e.Cep,e.Logradouro,e.Bairro,e.Cidade);
            }
        }
    }
}
