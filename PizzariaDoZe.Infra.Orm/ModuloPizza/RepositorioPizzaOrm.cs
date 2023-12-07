using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using PizzariaDoZe.Dominio.ModuloPizza;
using PizzariaDoZe.Infra.Orm.Compartilhado;

namespace PizzariaDoZe.Infra.Orm.ModuloPizza {
    public class RepositorioPizzaOrm : RepositorioBaseORM<Pizza>, IRepositorioPizza {
        public RepositorioPizzaOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        public List<Pizza> SelecionarTodos() {
            return registros.Include(x => x.Sabores).ToList();
        }
    }
}
