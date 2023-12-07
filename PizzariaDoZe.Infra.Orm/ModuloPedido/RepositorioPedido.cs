using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Dominio.ModuloPedido;
using PizzariaDoZe.Infra.Orm.Compartilhado;

namespace PedidoriaDoZe.Infra.Orm.ModuloPedido {
    public class RepositorioPedidoOrm : RepositorioBaseORM<Pedido>, IRepositorioPedido {
        public RepositorioPedidoOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        public List<Pedido> SelecionarTodos() {
            return registros.Include(x => x.Pizzas).Include(x => x.Bebidas).Include(x => x.Cliente).Include(x => x.Cliente.Endereco).ToList();
        }
    }
}
