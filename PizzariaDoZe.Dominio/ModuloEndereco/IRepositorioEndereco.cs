using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloEndereco {
    public interface IRepositorioEndereco: IRepositorio<Endereco> {
    
        void Inserir(Endereco endereco);

        Endereco SelecionarPorNome(string nome);

        Endereco SelecionarPorCep(string cep);
    }
}
