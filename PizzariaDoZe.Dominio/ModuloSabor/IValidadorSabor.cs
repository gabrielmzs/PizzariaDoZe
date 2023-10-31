using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloSabor {
    public interface IValidadorSabor: IValidador<Sabor> {

        public class ValidadorSabor: AbstractValidator<Sabor>,IValidadorSabor {

            public ValidadorSabor() {
                RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
            }
        }
    }
}


