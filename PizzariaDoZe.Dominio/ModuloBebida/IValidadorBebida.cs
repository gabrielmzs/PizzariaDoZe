using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloBebida {
    public interface IValidadorBebida: IValidador<Bebida> {

        public class ValidadorBebida: AbstractValidator<Bebida>, IValidadorBebida {
            public ValidadorBebida() {
                RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
            }
        }
    }
}
