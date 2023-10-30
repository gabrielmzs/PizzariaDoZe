using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloCliente {
    public class RepositorioClienteOrm : RepositorioBaseORM<Cliente>, IRepositorioCliente {
        public RepositorioClienteOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        //public void Inserir(Ingrediente ingrediente) {
        //    throw new NotImplementedException();
        //}

        public Cliente SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Cliente> SelecionarTodos() {
            return registros.Include(x => x.Endereco).ToList();
        }
    }
}
