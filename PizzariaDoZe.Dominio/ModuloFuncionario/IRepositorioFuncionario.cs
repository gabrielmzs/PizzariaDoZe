using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloFuncionario {
    public interface IRepositorioFuncionario : IRepositorio<Funcionario> {
        Funcionario SelecionarPorNome(string nome);
    }
}
