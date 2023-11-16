using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Dominio.ModuloValor;
using PizzariaDoZe.Infra.Orm.Compartilhado;

namespace PizzariaDoZe.Infra.Orm.ModuloValor {
    public class RepositorioValorOrm:RepositorioBaseORM<Valor>, IRepositorioValor {

        public RepositorioValorOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        public List<Valor> SelecionarTodos() {
            return registros.ToList();
        }
    }
}
