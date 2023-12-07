using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloPizza;

namespace PizzariaDoZe.Dominio.ModuloPedido {
    public class Pedido : EntidadeBase<Pedido> {

        public Cliente Cliente { get; set; }
        public DateTime Data {  get; set; }
        public TipoEntregaEnum Entrega { get; set; }
        public StatusPedidoEnum Status { get { return Status; } set { Status = StatusPedidoEnum.Confirmado; } }
        public FormaPagamentoEnum Pagamento { get; set; }
        public decimal ValorTotal {  get; set; }    
        public List<Pizza> Pizzas { get; set; }

        public string Observacao { get; set; }
        public List<Bebida> Bebidas { get; set; }   



        public override void Atualizar(Pedido registro) {
            throw new NotImplementedException();
        }
    }
}
