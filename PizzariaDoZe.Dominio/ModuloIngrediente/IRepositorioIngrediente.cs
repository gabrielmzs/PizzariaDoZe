using PizzariaDoZe.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloIngrediente {
    public interface IRepositorioIngrediente : IRepositorio<Ingrediente> {
        void Inserir(Ingrediente ingrediente);
        Ingrediente SelecionarPorNome(string nome);
    }
}
