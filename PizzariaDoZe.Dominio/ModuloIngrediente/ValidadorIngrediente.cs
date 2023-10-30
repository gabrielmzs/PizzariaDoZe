using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloIngrediente {
    public class ValidadorIngrediente : AbstractValidator<Ingrediente>, IValidadorIngrediente {

        public ValidadorIngrediente() {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}
