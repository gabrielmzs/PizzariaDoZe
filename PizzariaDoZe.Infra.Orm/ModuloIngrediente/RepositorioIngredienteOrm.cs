using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloIngrediente {
    public class RepositorioIngredienteOrm : RepositorioBaseORM<Ingrediente>, IRepositorioIngrediente {



        public RepositorioIngredienteOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        //public void Inserir(Ingrediente ingrediente) {
        //    throw new NotImplementedException();
        //}

        public Ingrediente SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
