using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Dominio.ModuloSabor;
using PizzariaDoZe.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloSabor {
    public class RepositorioSaborOrm : RepositorioBaseORM<Sabor>, IRepositorioSabor {
        public RepositorioSaborOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        //public void Inserir(Ingrediente ingrediente) {
        //    throw new NotImplementedException();
        //}

        public Sabor SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Sabor> SelecionarTodos() {
            return registros.Include(x => x.Ingredientes).ToList();
        }
    }
}
