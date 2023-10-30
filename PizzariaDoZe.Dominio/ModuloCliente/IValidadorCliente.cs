using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloCliente {
    public interface IValidadorCliente : IValidador<Cliente> {

        public class ValidadorCliente : AbstractValidator<Cliente>, IValidadorCliente {
            public ValidadorCliente() {
                RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);
                

            }
        }
    }
}
