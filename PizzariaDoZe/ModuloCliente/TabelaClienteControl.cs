using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloCliente {
    public partial class TabelaClienteControl : UserControl {
        public TabelaClienteControl() {
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

                new DataGridViewTextBoxColumn { Name = "Endereço", HeaderText = "Endereço", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Número", HeaderText = "Número", FillWeight=10F },
                new DataGridViewTextBoxColumn { Name = "Complemento", HeaderText = "Complemento", FillWeight=30F },

                new DataGridViewTextBoxColumn { Name = "CEP", HeaderText = "CEP", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", FillWeight=20F }
            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }
        public void AtualizarRegistros(List<Cliente> clientes) {
            grid.Rows.Clear();

            foreach (Cliente c in clientes) {

                grid.Rows.Add(c.Id, c.Nome, c.Endereco.Logradouro, c.NumeroDaCasa, c.Complemento, c.Endereco.Cep, c.Telefone);
            }
        }
    }
}
