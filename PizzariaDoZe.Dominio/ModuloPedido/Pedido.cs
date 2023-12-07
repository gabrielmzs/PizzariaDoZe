using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloPizza;

namespace PizzariaDoZe.Dominio.ModuloPedido {
    public class Pedido : EntidadeBase<Pedido> {

        public Cliente Cliente { get; set; }
        public DateTime Data {  get; set; }
        public TipoEntregaEnum Entrega { get; set; }
        public StatusPedidoEnum Status { get; set; }
        public FormaPagamentoEnum Pagamento { get; set; }
        public decimal ValorTotal {  get; set; }    
        public List<Pizza> Pizzas { get; set; }

        public string Observacao { get; set; }
        public List<Bebida> Bebidas { get; set; }

        public Pedido() {
        }

        public Pedido(Cliente cliente, DateTime data, TipoEntregaEnum entrega, StatusPedidoEnum status, FormaPagamentoEnum pagamento, decimal valorTotal, List<Pizza> pizzas, string observacao, List<Bebida> bebidas) {
            Cliente = cliente;
            Data = data;
            Entrega = entrega;
            Status = status;
            Pagamento = pagamento;
            ValorTotal = valorTotal;
            Pizzas = pizzas;
            Observacao = observacao;
            Bebidas = bebidas;
        }

        public override void Atualizar(Pedido registro) {
            throw new NotImplementedException();
        }
    }
}
