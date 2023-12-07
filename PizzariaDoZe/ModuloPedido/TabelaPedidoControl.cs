using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloPedido;

namespace PizzariaDoZe.ModuloPedido {
    public partial class TabelaPedidoControl : UserControl {
        public TabelaPedidoControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Cliente", FillWeight=40F },

                new DataGridViewTextBoxColumn { Name = "Endereço", HeaderText = "Endereço", FillWeight=30F },
                new DataGridViewTextBoxColumn { Name = "Entrega", HeaderText = "Entrega", FillWeight=10F },
                new DataGridViewTextBoxColumn { Name = "Valor Total", HeaderText = "Valor Total", FillWeight=30F },

                new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", FillWeight=20F },

                
            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }
        public void AtualizarRegistros(List<Pedido> pedidos) {
            grid.Rows.Clear();

            foreach (Pedido p in pedidos) {

                grid.Rows.Add(p.Id, p.Cliente.Nome, p.Cliente.Endereco.Logradouro + p.Cliente.NumeroDaCasa, p.Entrega, p.ValorTotal, p.Status);
            }
        }
    }
}
