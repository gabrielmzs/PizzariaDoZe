using PizzariaDoZe.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloCliente {
    public interface IRepositorioCliente : IRepositorio<Cliente> {
        Cliente SelecionarPorNome(string nome);
    }
}
