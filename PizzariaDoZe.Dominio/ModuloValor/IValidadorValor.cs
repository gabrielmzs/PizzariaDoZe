using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloValor {
    public interface IValidadorValor : IValidador<Valor> {
        public class ValidadorValor : AbstractValidator<Valor>, IValidadorValor {
            public ValidadorValor() {
                RuleFor(x => x.ValorPizza).NotEmpty().NotNull();
                RuleFor(x => x.ValorBorda).NotEmpty().NotNull();
            }
        }
    }
}
