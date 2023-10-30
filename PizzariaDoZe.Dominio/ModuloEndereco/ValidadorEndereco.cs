using FluentValidation;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloEndereco {
    public class ValidadorEndereco: AbstractValidator<Endereco>,IValidadorEndereco {

            public ValidadorEndereco() {
                RuleFor(x => x.Logradouro)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(3);
            }
        
    }
}
