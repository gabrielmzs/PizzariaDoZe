using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloPizza {
    public interface IValidadorPizza : IValidador<Pizza> {
        public class ValidadorPizza : AbstractValidator<Pizza>, IValidadorPizza{
            public ValidadorPizza() {
                RuleFor(x => x.Valor).NotEmpty().NotNull();
                RuleFor(x => x.Sabores).NotEmpty().NotNull();
            }
        }
    }
}
