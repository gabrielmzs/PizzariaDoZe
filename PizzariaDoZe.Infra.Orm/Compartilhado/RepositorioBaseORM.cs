using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.Compartilhado {
    public class RepositorioBaseORM<T> : IRepositorio<T> where T : EntidadeBase<T> {

        protected readonly PizzariaDoZeDbContext dbContext;
        protected DbSet<T> registros;

        public RepositorioBaseORM(PizzariaDoZeDbContext dbContext) {
            this.dbContext = dbContext;
            registros = dbContext.Set<T>();
        }
        public void Inserir(T novoRegistro) {
            registros.Add(novoRegistro);

            dbContext.SaveChanges();
        }

        public void Editar(T registro) {
            registros.Update(registro);

            dbContext.SaveChanges();
        }

        public void Excluir(T registro) {
            registros.Remove(registro);

            dbContext.SaveChanges();
        }

        public bool Existe(T registro) {
            return registros.Contains(registro);
        }

        public T SelecionarPorId(Guid id) {
            return registros.Find(id);
        }

        public List<T> SelecionarTodos() {
            return registros.ToList();
        }
    }
}
