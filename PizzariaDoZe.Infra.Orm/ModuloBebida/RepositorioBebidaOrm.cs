using PizzariaDoZe.Dominio.ModuloBebida;
using PizzariaDoZe.Infra.Orm.Compartilhado;

namespace PizzariaDoZe.Infra.Orm.ModuloBebida {
    public class RepositorioBebidaOrm : RepositorioBaseORM<Bebida>, IRepositorioBebida {

        public RepositorioBebidaOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }
        public Bebida SelecionarPorNome(string nome) {
            throw new NotImplementedException();
        }

        public List<Bebida> SelecionarTodos() {
            return registros.ToList();
        }
    }
}
