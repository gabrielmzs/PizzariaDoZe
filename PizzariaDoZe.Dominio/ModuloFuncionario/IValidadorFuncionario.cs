using FluentValidation;
using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloFuncionario {
    public interface IValidadorFuncionario : IValidador<Funcionario> {

        public class ValidadorFuncionario : AbstractValidator<Funcionario>, IValidadorFuncionario {
            public ValidadorFuncionario() {
                RuleFor(x => x.Nome).NotEmpty().NotNull().MinimumLength(3);


            }
        }
    }
}
