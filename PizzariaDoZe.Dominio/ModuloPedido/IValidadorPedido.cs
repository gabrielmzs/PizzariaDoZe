using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloPedido;

namespace PedidoriaDoZe.Dominio.ModuloPedido {
    public interface IValidadorPedido : IValidador<Pedido> {
        public class ValidadorPedido : AbstractValidator<Pedido>, IValidadorPedido {
            public ValidadorPedido() {
                RuleFor(x => x.Cliente).NotEmpty().NotNull();
                RuleFor(x => x.Pizzas).NotEmpty().NotNull();
            }
        }
    }
}
